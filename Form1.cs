using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;
using 文件监控处理应用.Models;

namespace 文件监控处理应用 {
    public partial class 文件监控 : Form {

        public 文件监控() {
            InitializeComponent();
            dgv_FileList.DataSource = fileTasks;
        }

        private FileSystemWatcher watcher;
        private List<string> filters = new List<string>();
        private BindingList<FileTask> fileTasks = new BindingList<FileTask>();
        private CancellationTokenSource cts;
        private ManualResetEvent mre;
        private bool isPaused;
        private bool isRunning = false;

        private void btn_OpenMonitorFiles_Click(object sender, EventArgs e) {
            string path = DirSelect();
            this.txt_MonitorDir.Text = path;
            AppendLog($"监控路径：{path}");
        }
        private void btn_OpenTargetFiles_Click(object sender, EventArgs e) {
            string path = DirSelect();
            this.txt_TargetDir.Text = path;
            AppendLog($"目标路径：{path}");
        }

        private string DirSelect() {
            if (FolderDialog.ShowDialog() == DialogResult.OK) {
                return FolderDialog.SelectedPath;
            }
            return null;
        }

        private void btn_StartMonitor_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txt_MonitorDir.Text)) MessageBox.Show("请先选择监控文件夹", "提示", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            string path = txt_MonitorDir.Text;
            if (!Directory.Exists(path)) return;
            foreach (var item in gb_Filter.Controls) {
                if (item is CheckBox cb && cb.Checked) {
                    filters.Add(cb.Text.ToLower().Replace("*", ""));
                }
            }
            watcher = new FileSystemWatcher(path);
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
            watcher.Filter = "*.*";
            watcher.Created += OnFileCreate;
            lbl_Monitor.Text = "监控中...";
            AppendLog($"启动监控-监控类型:{string.Join(";", filters.ToArray())}");
        }

        private void btn_StopMonitor_Click(object sender, EventArgs e) {
            if (watcher != null) watcher.Created -= OnFileCreate;
            lbl_Monitor.Text = "";
            AppendLog("停止监控");
        }

        private void OnFileCreate(object sender, FileSystemEventArgs e) {
            string ext = Path.GetExtension(e.FullPath).ToLower();
            if (filters.Contains(ext) || filters.Count == 0) {
                this.Invoke(new Action(() => AddFileToList(e.FullPath)));
            }
        }

        private void AddFileToList(string str) {
            AddFileTasks(new List<string> { str});
        }

        private void btn_AddFiles_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Multiselect = true;
                ofd.Title = "请选择要处理的文件";
                List<string> filePaths = new List<string>();
                if (ofd.ShowDialog() == DialogResult.OK) {
                    foreach (var file in ofd.FileNames) {
                        filePaths.Add(file);
                    }
                }
                AddFileTasks(filePaths);
            }
        }

        private void AddFileTasks(List<string> filePaths) {
            foreach (var file in filePaths) {
                FileInfo fileInfo = new FileInfo(file);
                FileTask fileTask = new FileTask() {
                    FileName = fileInfo.Name,
                    FilePath = fileInfo.FullName,
                    FileSizeBytes = fileInfo.Length,
                    Status = FileStatus.等待中
                };
                fileTasks.Add(fileTask);
                AppendLog($"添加文件：{fileInfo.Name}");
            }
        }

        private void btn_DelFiles_Click(object sender, EventArgs e) {
            if (dgv_FileList.SelectedRows.Count <= 0) {
                MessageBox.Show("请选择要删除的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            List<FileTask> toRemove = new List<FileTask>();
            foreach (DataGridViewRow row in dgv_FileList.SelectedRows) {
                FileTask task = row.DataBoundItem as FileTask;
                if (task != null && task.Status == FileStatus.等待中) {
                    toRemove.Add(task);
                }
            }
            foreach (var task in toRemove) {
                fileTasks.Remove(task);
                AppendLog($"删除文件：{task.FileName}");
            }
        }

        private void btn_ClearFiles_Click(object sender, EventArgs e) {
            List<FileTask> toRemove = new List<FileTask>();
            foreach (var task in fileTasks) {
                if(task != null && (task.Status == FileStatus.等待中 || task.Status == FileStatus.已完成)) {
                    toRemove.Add(task);
                }
            }
            foreach (var task in toRemove) {
                fileTasks.Remove(task);
            }
            AppendLog("清空列表");
        }

        private async void btn_Start_Click(object sender, EventArgs e) {
            if (fileTasks.Count <= 0) { MessageBox.Show("没有待处理文件"); return; } 
            if (string.IsNullOrEmpty(txt_TargetDir.Text)) { MessageBox.Show("请选择目标文件夹"); return; }
            if (!(rb_AddPre.Checked || rb_CopyTo.Checked || rb_ToZip.Checked)) { MessageBox.Show("请选择处理方式"); return; }
            if (rb_AddPre.Checked && string.IsNullOrEmpty(txt_Pre.Text)) { MessageBox.Show("请输入前缀"); return; }
            cts = new CancellationTokenSource();
            mre = new ManualResetEvent(true);
            progressBar.Value = 0;
            isPaused = false;
            isRunning = true;
            btn_Start.Enabled = false;
            lbl_ProgessBar.Text = "处理中...";
            await ProcessFiles(cts.Token);
            btn_Start.Enabled = true;
            lbl_ProgessBar.Text = "";
        }

        private async Task ProcessFiles(CancellationToken token) {
            List<FileTask> toProcess = fileTasks.Where(t => t.Status.Equals(FileStatus.等待中)).ToList();
            if (toProcess.Count <= 0) { MessageBox.Show("没有待处理的文件"); return; }
            progressBar.Maximum = toProcess.Count;

            int dealtWith = 0;
            int sucessCount = 0;
            int failCount = 0;

            int taskCount = (int)nud_TaskCount.Value;
            SemaphoreSlim sem = new SemaphoreSlim(taskCount);
            AppendLog($"处理规则：{GetRule()}，前缀：{txt_Pre.Text}，并发数：{nud_TaskCount.Value}");
            IEnumerable<Task> tasks = toProcess.Select(async task => {
                AppendLog($"开始处理：{task.FileName}");
                await sem.WaitAsync();
                try {
                    task.Status = FileStatus.处理中;
                    bool result = await ProcessOnFiles(task, token);
                    task.Status = result ? FileStatus.已完成 : FileStatus.处理失败;
                    if (result) sucessCount++; else failCount++;
                    UpdateStatus();
                } catch (Exception e) {
                    task.Status = FileStatus.处理失败;
                    failCount++;
                    UpdateStatus();
                } finally {
                    dealtWith++;
                    progressBar.Value = dealtWith;
                    sem.Release();
                }
                AppendLog($"处理结束：{task.FileName}");
            });
            await Task.WhenAll(tasks);
            lbl_ProgessBar.Text = "处理完成";
        }

        private async Task<bool> ProcessOnFiles(FileTask task, CancellationToken token) {
            if (token.IsCancellationRequested) {
                return false ;
            }
            mre.WaitOne();
            return await Task.Run(async () => {
                try {
                    if (rb_AddPre.Checked) {
                        await Task.Delay(5000);
                        return AddPreFile(task);
                    } else if (rb_CopyTo.Checked) {
                        return CopyToFile(task);
                    } else if (rb_ToZip.Checked) {
                        await Task.Delay(5000);
                        return ToZipFile(task);
                    }
                    return false;
                } catch (Exception e) {
                    return false;
                }
            });
        }

        private bool CopyToFile(FileTask task) {
            string targetFilePath = Path.Combine(txt_TargetDir.Text, task.FileName);
            try {
                File.Copy(task.FilePath, targetFilePath, true);
            } catch (Exception) {
                return false;
            }
            return true;
        }

        private bool AddPreFile(FileTask task) {
            string fileNamePath = Path.Combine(txt_TargetDir.Text, txt_Pre.Text + task.FileName);
            try {
                File.Copy(task.FilePath, fileNamePath, true);
            } catch (Exception) {
                return false;
            }
            return true;
        }

        private bool ToZipFile(FileTask task) {
            string zipPath = Path.Combine(txt_TargetDir.Text, Path.GetFileNameWithoutExtension(task.FilePath) + ".zip");
            try {
                using (var archive = ZipFile.Open(zipPath, ZipArchiveMode.Create)) {
                    archive.CreateEntryFromFile(task.FilePath, Path.GetFileName(task.FileName));
                }
            } catch (Exception) {
                return false;
            }
            return true;
        }

        private void btn_Pouse_Click(object sender, EventArgs e) {
            if (isRunning) {
                if (isPaused) return;
                isPaused = true;
                mre.Reset();
                btn_Pouse.Enabled = false;
                btn_Resume.Enabled = true;
                lbl_ProgessBar.Text = "已暂停...";
                AppendLog("暂停");
            } else {
                MessageBox.Show("请先开始处理");
            }
        }

        private void btn_Resume_Click(object sender, EventArgs e) {
            if (isRunning) {
                if (!isPaused) return;
                isPaused = false;
                mre.Set();
                btn_Pouse.Enabled = true;
                btn_Resume.Enabled = false;
                lbl_ProgessBar.Text = "处理中...";
                AppendLog("继续");
            } else {
                MessageBox.Show("请先开始处理");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            if(isRunning) {
                btn_Pouse.Enabled = true;
                btn_Resume.Enabled = true;
                lbl_ProgessBar.Text = "";
                cts?.Cancel();
                mre?.Set();
                AppendLog("取消");
            } else {
                MessageBox.Show("请先开始处理");
            }
        }

        private string GetRule() {
            if (rb_AddPre.Checked) return rb_AddPre.Text;
            if (rb_CopyTo.Checked) return rb_CopyTo.Text;
            if (rb_ToZip.Checked) return rb_ToZip.Text;
            return "";
        }

        private string GetFilters() {
            List<string> ffis = new List<string>();
            foreach (var item in gb_Filter.Controls) {
                if (item is CheckBox cb && cb.Checked) {
                    ffis.Add(cb.Text.ToLower().Replace("*", ""));
                }
            }
            return string.Join(";", ffis.ToArray());
        }

        private void AppendLog(string msg) {
            if (rtb_Log.InvokeRequired) {
                rtb_Log.Invoke(new Action(() => AppendLog(msg)));
            }
            rtb_Log.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\n");
            rtb_Log.ScrollToCaret();
        }

        private void AppendLog(string msg, Color color) {
            if (rtb_Log.InvokeRequired) {
                rtb_Log.Invoke(new Action(() => AppendLog(msg, color)));
            }
            rtb_Log.SelectionStart = rtb_Log.TextLength;
            rtb_Log.SelectionColor = color;
            rtb_Log.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\n");
            rtb_Log.ScrollToCaret();
        }

        private void LogInfo(string msg) => AppendLog(msg, Color.Black);
        private void LogSuccess(string msg) => AppendLog(msg, Color.Green);
        private void LogError(string msg) => AppendLog(msg, Color.Red);
        private void LogWarning(string msg) => AppendLog(msg, Color.Orange);

        private void btn_ClearLog_Click(object sender, EventArgs e) {
            rtb_Log.Clear();
        }
        
        private void btn_ExportLog_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txt_TargetDir.Text)) MessageBox.Show("请选择目标文件夹");
            string suffix = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string path = Path.Combine(txt_TargetDir.Text, "log-" + suffix);
            try {
                File.AppendAllText(path, rtb_Log.Text);
            } catch (Exception ex) {
                MessageBox.Show("导出日志失败");
                LogError($"导出日志失败：{ex.Message}");
            }
        }

        private void btn_SaveConfig_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txt_TargetDir.Text)) MessageBox.Show("请选择目标文件夹"); 
            Config config = new Config();
            config.MonitorDir = txt_MonitorDir.Text;
            config.TargetDir = txt_TargetDir.Text;
            config.Filters = GetFilters();
            config.Rulers = GetRule();
            config.PreText = txt_Pre.Text;
            config.TaskCount = (int)nud_TaskCount.Value;
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            string suffix = "config" + DateTime.Now.ToString("yyyy-MM-dd") + ".json";
            string path = Path.Combine(txt_TargetDir.Text, suffix);
            try {
                File.WriteAllText(path, json);
                MessageBox.Show("保存配置成功");
                LogSuccess($"保存配置成功：{suffix}");
            } catch (Exception ex) {
                MessageBox.Show("保存配置失败");
                LogError($"保存配置失败：{ex.Message}");
            }
        }

        private void btn_LoadConfig_Click(object sender, EventArgs e) {
            string path = "";
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Multiselect = false;
                ofd.Title = "请选择文件";
                ofd.Filter = "Json文件|*.json";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    path = ofd.FileName;
                }
            }
            Config config = new Config();
            try {
                string json = File.ReadAllText(path);
                config = JsonConvert.DeserializeObject<Config>(json);
            } catch (Exception ex) {
                MessageBox.Show("读取配置文件失败");
                LogError($"读取配置文件失败:{ex.Message}");
                return;
            }
            string monitorDir = config.MonitorDir;
            string targetDir = config.TargetDir;
            string filters = config.Filters;
            string rulers = config.Rulers;
            string preText = config.PreText;
            int taskCount = config.TaskCount;
            if (!string.IsNullOrEmpty(monitorDir)) txt_MonitorDir.Text = monitorDir;
            if (!string.IsNullOrEmpty(targetDir)) txt_TargetDir.Text = targetDir;
            if (!string.IsNullOrEmpty(preText)) txt_Pre.Text = config.PreText;
            if (taskCount > 0 && taskCount < 10) nud_TaskCount.Value = taskCount;
            if (!string.IsNullOrEmpty(filters)) {
                string[] fils = filters.Split(';');
                foreach (var filter in fils) {
                    if (cb_Log.Text.Replace("*", "") == filter) cb_Log.Checked = true;
                    if (cb_Txt.Text.Replace("*", "") == filter) cb_Txt.Checked = true;
                    if (cb_Csv.Text.Replace("*", "") == filter) cb_Csv.Checked = true;
                }
            }
            if (!string.IsNullOrEmpty(rulers)) {
                if (rb_AddPre.Text == rulers) rb_AddPre.Checked = true;
                if (rb_CopyTo.Text == rulers) rb_CopyTo.Checked = true;
                if (rb_ToZip.Text == rulers) rb_ToZip.Checked = true;
            }
            LogSuccess("加载配置成功");
        }

        private void UpdateStatus() {
            lbl_Total.Text = $"总文件：{fileTasks.Count}";
            lbl_Success.Text = $"成功：{fileTasks.Count(x => x.Status == FileStatus.已完成)}";
            lbl_Fail.Text = $"失败：{fileTasks.Count(x => x.Status == FileStatus.处理失败)}";
        }

    }
}
