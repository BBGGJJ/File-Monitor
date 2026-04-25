namespace 文件监控处理应用 {
    partial class 文件监控 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.lbl_Monitor = new System.Windows.Forms.Label();
            this.cb_Csv = new System.Windows.Forms.CheckBox();
            this.cb_Txt = new System.Windows.Forms.CheckBox();
            this.cb_Log = new System.Windows.Forms.CheckBox();
            this.btn_StopMonitor = new System.Windows.Forms.Button();
            this.btn_StartMonitor = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_OpenMonitorFiles = new System.Windows.Forms.Button();
            this.txt_MonitorDir = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgv_FileList = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ClearFiles = new System.Windows.Forms.Button();
            this.btn_DelFiles = new System.Windows.Forms.Button();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.btn_ClearLog = new System.Windows.Forms.Button();
            this.btn_ExportLog = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_Fail = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.lbl_Success = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nud_TaskCount = new System.Windows.Forms.NumericUpDown();
            this.txt_Pre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_AddPre = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btn_OpenTargetFiles = new System.Windows.Forms.Button();
            this.txt_TargetDir = new System.Windows.Forms.TextBox();
            this.rb_CopyTo = new System.Windows.Forms.RadioButton();
            this.rb_ToZip = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_ProgessBar = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Pouse = new System.Windows.Forms.Button();
            this.btn_SaveConfig = new System.Windows.Forms.Button();
            this.btn_LoadConfig = new System.Windows.Forms.Button();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.gb_Filter.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FileList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TaskCount)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gb_Filter);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "【监控配置区】";
            // 
            // gb_Filter
            // 
            this.gb_Filter.Controls.Add(this.lbl_Monitor);
            this.gb_Filter.Controls.Add(this.cb_Csv);
            this.gb_Filter.Controls.Add(this.cb_Txt);
            this.gb_Filter.Controls.Add(this.cb_Log);
            this.gb_Filter.Controls.Add(this.btn_StopMonitor);
            this.gb_Filter.Controls.Add(this.btn_StartMonitor);
            this.gb_Filter.Location = new System.Drawing.Point(6, 114);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Size = new System.Drawing.Size(295, 121);
            this.gb_Filter.TabIndex = 0;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "文件过滤类型(不选默认全部文件)：";
            // 
            // lbl_Monitor
            // 
            this.lbl_Monitor.AutoSize = true;
            this.lbl_Monitor.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Monitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Monitor.Location = new System.Drawing.Point(183, 81);
            this.lbl_Monitor.Name = "lbl_Monitor";
            this.lbl_Monitor.Size = new System.Drawing.Size(0, 26);
            this.lbl_Monitor.TabIndex = 3;
            // 
            // cb_Csv
            // 
            this.cb_Csv.AutoSize = true;
            this.cb_Csv.Location = new System.Drawing.Point(214, 21);
            this.cb_Csv.Name = "cb_Csv";
            this.cb_Csv.Size = new System.Drawing.Size(54, 16);
            this.cb_Csv.TabIndex = 2;
            this.cb_Csv.Text = "*.csv";
            this.cb_Csv.UseVisualStyleBackColor = true;
            // 
            // cb_Txt
            // 
            this.cb_Txt.AutoSize = true;
            this.cb_Txt.Location = new System.Drawing.Point(120, 21);
            this.cb_Txt.Name = "cb_Txt";
            this.cb_Txt.Size = new System.Drawing.Size(54, 16);
            this.cb_Txt.TabIndex = 2;
            this.cb_Txt.Text = "*.txt";
            this.cb_Txt.UseVisualStyleBackColor = true;
            // 
            // cb_Log
            // 
            this.cb_Log.AutoSize = true;
            this.cb_Log.Location = new System.Drawing.Point(17, 21);
            this.cb_Log.Name = "cb_Log";
            this.cb_Log.Size = new System.Drawing.Size(54, 16);
            this.cb_Log.TabIndex = 2;
            this.cb_Log.Text = "*.log";
            this.cb_Log.UseVisualStyleBackColor = true;
            // 
            // btn_StopMonitor
            // 
            this.btn_StopMonitor.Location = new System.Drawing.Point(99, 83);
            this.btn_StopMonitor.Name = "btn_StopMonitor";
            this.btn_StopMonitor.Size = new System.Drawing.Size(75, 23);
            this.btn_StopMonitor.TabIndex = 1;
            this.btn_StopMonitor.Text = "停止监控";
            this.btn_StopMonitor.UseVisualStyleBackColor = true;
            this.btn_StopMonitor.Click += new System.EventHandler(this.btn_StopMonitor_Click);
            // 
            // btn_StartMonitor
            // 
            this.btn_StartMonitor.Location = new System.Drawing.Point(17, 83);
            this.btn_StartMonitor.Name = "btn_StartMonitor";
            this.btn_StartMonitor.Size = new System.Drawing.Size(75, 23);
            this.btn_StartMonitor.TabIndex = 1;
            this.btn_StartMonitor.Text = "启动监控";
            this.btn_StartMonitor.UseVisualStyleBackColor = true;
            this.btn_StartMonitor.Click += new System.EventHandler(this.btn_StartMonitor_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_OpenMonitorFiles);
            this.groupBox7.Controls.Add(this.txt_MonitorDir);
            this.groupBox7.Location = new System.Drawing.Point(6, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(295, 79);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "监控文件夹：";
            // 
            // btn_OpenMonitorFiles
            // 
            this.btn_OpenMonitorFiles.Location = new System.Drawing.Point(214, 48);
            this.btn_OpenMonitorFiles.Name = "btn_OpenMonitorFiles";
            this.btn_OpenMonitorFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenMonitorFiles.TabIndex = 1;
            this.btn_OpenMonitorFiles.Text = "浏览";
            this.btn_OpenMonitorFiles.UseVisualStyleBackColor = true;
            this.btn_OpenMonitorFiles.Click += new System.EventHandler(this.btn_OpenMonitorFiles_Click);
            // 
            // txt_MonitorDir
            // 
            this.txt_MonitorDir.Enabled = false;
            this.txt_MonitorDir.Location = new System.Drawing.Point(7, 21);
            this.txt_MonitorDir.Name = "txt_MonitorDir";
            this.txt_MonitorDir.Size = new System.Drawing.Size(282, 21);
            this.txt_MonitorDir.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.btn_ClearFiles);
            this.groupBox2.Controls.Add(this.btn_DelFiles);
            this.groupBox2.Controls.Add(this.btn_AddFiles);
            this.groupBox2.Location = new System.Drawing.Point(354, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 384);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "【文件处理区】";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dgv_FileList);
            this.groupBox9.Location = new System.Drawing.Point(16, 21);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(285, 315);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "拖拽文件到此处或点击添加";
            // 
            // dgv_FileList
            // 
            this.dgv_FileList.AllowUserToAddRows = false;
            this.dgv_FileList.AllowUserToDeleteRows = false;
            this.dgv_FileList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_FileList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FileList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_FileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileSize,
            this.Status,
            this.FilePath,
            this.Column2});
            this.dgv_FileList.Location = new System.Drawing.Point(13, 20);
            this.dgv_FileList.Name = "dgv_FileList";
            this.dgv_FileList.ReadOnly = true;
            this.dgv_FileList.RowHeadersVisible = false;
            this.dgv_FileList.RowTemplate.Height = 23;
            this.dgv_FileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FileList.Size = new System.Drawing.Size(272, 283);
            this.dgv_FileList.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "文件名";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 140;
            // 
            // FileSize
            // 
            this.FileSize.DataPropertyName = "FileSize";
            this.FileSize.HeaderText = "大小";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.Width = 70;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // FilePath
            // 
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "FilePath";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FileSizeBytes";
            this.Column2.HeaderText = "FileSizeBytes";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // btn_ClearFiles
            // 
            this.btn_ClearFiles.Location = new System.Drawing.Point(226, 350);
            this.btn_ClearFiles.Name = "btn_ClearFiles";
            this.btn_ClearFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearFiles.TabIndex = 1;
            this.btn_ClearFiles.Text = "清空列表";
            this.btn_ClearFiles.UseVisualStyleBackColor = true;
            this.btn_ClearFiles.Click += new System.EventHandler(this.btn_ClearFiles_Click);
            // 
            // btn_DelFiles
            // 
            this.btn_DelFiles.Location = new System.Drawing.Point(126, 350);
            this.btn_DelFiles.Name = "btn_DelFiles";
            this.btn_DelFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_DelFiles.TabIndex = 1;
            this.btn_DelFiles.Text = "删除选中";
            this.btn_DelFiles.UseVisualStyleBackColor = true;
            this.btn_DelFiles.Click += new System.EventHandler(this.btn_DelFiles_Click);
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.Location = new System.Drawing.Point(23, 350);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFiles.TabIndex = 1;
            this.btn_AddFiles.Text = "添加文件";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.btn_AddFiles_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.rtb_Log);
            this.groupBox3.Controls.Add(this.btn_ClearLog);
            this.groupBox3.Controls.Add(this.btn_ExportLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 520);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 229);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "【日志输出区】";
            // 
            // rtb_Log
            // 
            this.rtb_Log.Enabled = false;
            this.rtb_Log.Location = new System.Drawing.Point(17, 20);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Size = new System.Drawing.Size(289, 165);
            this.rtb_Log.TabIndex = 0;
            this.rtb_Log.Text = "";
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Location = new System.Drawing.Point(198, 191);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearLog.TabIndex = 1;
            this.btn_ClearLog.Text = "清空日志";
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // btn_ExportLog
            // 
            this.btn_ExportLog.Location = new System.Drawing.Point(43, 191);
            this.btn_ExportLog.Name = "btn_ExportLog";
            this.btn_ExportLog.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportLog.TabIndex = 1;
            this.btn_ExportLog.Text = "导出日志";
            this.btn_ExportLog.UseVisualStyleBackColor = true;
            this.btn_ExportLog.Click += new System.EventHandler(this.btn_ExportLog_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_Fail);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.lbl_Success);
            this.groupBox4.Controls.Add(this.lbl_Total);
            this.groupBox4.Location = new System.Drawing.Point(354, 565);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 140);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "【统计区】";
            // 
            // lbl_Fail
            // 
            this.lbl_Fail.AutoSize = true;
            this.lbl_Fail.Location = new System.Drawing.Point(230, 38);
            this.lbl_Fail.Name = "lbl_Fail";
            this.lbl_Fail.Size = new System.Drawing.Size(41, 12);
            this.lbl_Fail.TabIndex = 1;
            this.lbl_Fail.Text = "失败：";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(16, 90);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "导出报告";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // lbl_Success
            // 
            this.lbl_Success.AutoSize = true;
            this.lbl_Success.Location = new System.Drawing.Point(136, 38);
            this.lbl_Success.Name = "lbl_Success";
            this.lbl_Success.Size = new System.Drawing.Size(41, 12);
            this.lbl_Success.TabIndex = 1;
            this.lbl_Success.Text = "成功：";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(21, 38);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(53, 12);
            this.lbl_Total.TabIndex = 1;
            this.lbl_Total.Text = "总文件：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nud_TaskCount);
            this.groupBox5.Controls.Add(this.txt_Pre);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.rb_AddPre);
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.rb_CopyTo);
            this.groupBox5.Controls.Add(this.rb_ToZip);
            this.groupBox5.Location = new System.Drawing.Point(12, 274);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 240);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "【处理规则】";
            // 
            // nud_TaskCount
            // 
            this.nud_TaskCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_TaskCount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nud_TaskCount.Location = new System.Drawing.Point(65, 190);
            this.nud_TaskCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_TaskCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_TaskCount.Name = "nud_TaskCount";
            this.nud_TaskCount.ReadOnly = true;
            this.nud_TaskCount.Size = new System.Drawing.Size(51, 26);
            this.nud_TaskCount.TabIndex = 4;
            this.nud_TaskCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txt_Pre
            // 
            this.txt_Pre.Location = new System.Drawing.Point(214, 55);
            this.txt_Pre.Name = "txt_Pre";
            this.txt_Pre.Size = new System.Drawing.Size(81, 21);
            this.txt_Pre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "(1-10)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "前缀：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "并发数：";
            // 
            // rb_AddPre
            // 
            this.rb_AddPre.AutoSize = true;
            this.rb_AddPre.Location = new System.Drawing.Point(179, 28);
            this.rb_AddPre.Name = "rb_AddPre";
            this.rb_AddPre.Size = new System.Drawing.Size(95, 16);
            this.rb_AddPre.TabIndex = 0;
            this.rb_AddPre.TabStop = true;
            this.rb_AddPre.Text = "文件名加前缀";
            this.rb_AddPre.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btn_OpenTargetFiles);
            this.groupBox10.Controls.Add(this.txt_TargetDir);
            this.groupBox10.Location = new System.Drawing.Point(17, 97);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(295, 79);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "目标文件夹";
            // 
            // btn_OpenTargetFiles
            // 
            this.btn_OpenTargetFiles.Location = new System.Drawing.Point(214, 48);
            this.btn_OpenTargetFiles.Name = "btn_OpenTargetFiles";
            this.btn_OpenTargetFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenTargetFiles.TabIndex = 1;
            this.btn_OpenTargetFiles.Text = "浏览";
            this.btn_OpenTargetFiles.UseVisualStyleBackColor = true;
            this.btn_OpenTargetFiles.Click += new System.EventHandler(this.btn_OpenTargetFiles_Click);
            // 
            // txt_TargetDir
            // 
            this.txt_TargetDir.Enabled = false;
            this.txt_TargetDir.Location = new System.Drawing.Point(7, 20);
            this.txt_TargetDir.Name = "txt_TargetDir";
            this.txt_TargetDir.Size = new System.Drawing.Size(282, 21);
            this.txt_TargetDir.TabIndex = 0;
            // 
            // rb_CopyTo
            // 
            this.rb_CopyTo.AutoSize = true;
            this.rb_CopyTo.Location = new System.Drawing.Point(23, 60);
            this.rb_CopyTo.Name = "rb_CopyTo";
            this.rb_CopyTo.Size = new System.Drawing.Size(95, 16);
            this.rb_CopyTo.TabIndex = 0;
            this.rb_CopyTo.TabStop = true;
            this.rb_CopyTo.Text = "复制到文件夹";
            this.rb_CopyTo.UseVisualStyleBackColor = true;
            // 
            // rb_ToZip
            // 
            this.rb_ToZip.AutoSize = true;
            this.rb_ToZip.Location = new System.Drawing.Point(23, 28);
            this.rb_ToZip.Name = "rb_ToZip";
            this.rb_ToZip.Size = new System.Drawing.Size(77, 16);
            this.rb_ToZip.TabIndex = 0;
            this.rb_ToZip.TabStop = true;
            this.rb_ToZip.Text = "压缩为Zip";
            this.rb_ToZip.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_ProgessBar);
            this.groupBox6.Controls.Add(this.progressBar);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.btn_Cancel);
            this.groupBox6.Controls.Add(this.btn_Resume);
            this.groupBox6.Controls.Add(this.btn_Start);
            this.groupBox6.Controls.Add(this.btn_Pouse);
            this.groupBox6.Location = new System.Drawing.Point(355, 416);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(318, 135);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "【处理进度】";
            // 
            // lbl_ProgessBar
            // 
            this.lbl_ProgessBar.AutoSize = true;
            this.lbl_ProgessBar.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ProgessBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_ProgessBar.Location = new System.Drawing.Point(23, 68);
            this.lbl_ProgessBar.Name = "lbl_ProgessBar";
            this.lbl_ProgessBar.Size = new System.Drawing.Size(0, 19);
            this.lbl_ProgessBar.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(87, 30);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(203, 23);
            this.progressBar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "整体进度：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(241, 99);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(49, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Resume
            // 
            this.btn_Resume.Location = new System.Drawing.Point(173, 99);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(49, 23);
            this.btn_Resume.TabIndex = 1;
            this.btn_Resume.Text = "继续";
            this.btn_Resume.UseVisualStyleBackColor = true;
            this.btn_Resume.Click += new System.EventHandler(this.btn_Resume_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.White;
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.Location = new System.Drawing.Point(15, 100);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "开始处理";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Pouse
            // 
            this.btn_Pouse.Location = new System.Drawing.Point(108, 99);
            this.btn_Pouse.Name = "btn_Pouse";
            this.btn_Pouse.Size = new System.Drawing.Size(50, 23);
            this.btn_Pouse.TabIndex = 1;
            this.btn_Pouse.Text = "暂停";
            this.btn_Pouse.UseVisualStyleBackColor = true;
            this.btn_Pouse.Click += new System.EventHandler(this.btn_Pouse_Click);
            // 
            // btn_SaveConfig
            // 
            this.btn_SaveConfig.Location = new System.Drawing.Point(574, 720);
            this.btn_SaveConfig.Name = "btn_SaveConfig";
            this.btn_SaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveConfig.TabIndex = 1;
            this.btn_SaveConfig.Text = "保存配置";
            this.btn_SaveConfig.UseVisualStyleBackColor = true;
            this.btn_SaveConfig.Click += new System.EventHandler(this.btn_SaveConfig_Click);
            // 
            // btn_LoadConfig
            // 
            this.btn_LoadConfig.Location = new System.Drawing.Point(480, 720);
            this.btn_LoadConfig.Name = "btn_LoadConfig";
            this.btn_LoadConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadConfig.TabIndex = 1;
            this.btn_LoadConfig.Text = "加载配置";
            this.btn_LoadConfig.UseVisualStyleBackColor = true;
            this.btn_LoadConfig.Click += new System.EventHandler(this.btn_LoadConfig_Click);
            // 
            // 文件监控
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_LoadConfig);
            this.Controls.Add(this.btn_SaveConfig);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "文件监控";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件批量处理助手";
            this.groupBox1.ResumeLayout(false);
            this.gb_Filter.ResumeLayout(false);
            this.gb_Filter.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FileList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TaskCount)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_OpenMonitorFiles;
        private System.Windows.Forms.TextBox txt_MonitorDir;
        private System.Windows.Forms.GroupBox gb_Filter;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_StartMonitor;
        private System.Windows.Forms.CheckBox cb_Csv;
        private System.Windows.Forms.CheckBox cb_Txt;
        private System.Windows.Forms.CheckBox cb_Log;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgv_FileList;
        private System.Windows.Forms.Button btn_Resume;
        private System.Windows.Forms.Button btn_Pouse;
        private System.Windows.Forms.Button btn_StopMonitor;
        private System.Windows.Forms.RadioButton rb_AddPre;
        private System.Windows.Forms.RadioButton rb_CopyTo;
        private System.Windows.Forms.RadioButton rb_ToZip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btn_OpenTargetFiles;
        private System.Windows.Forms.TextBox txt_TargetDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Button btn_ClearLog;
        private System.Windows.Forms.Button btn_ExportLog;
        private System.Windows.Forms.Label lbl_Fail;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label lbl_Success;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_SaveConfig;
        private System.Windows.Forms.Button btn_LoadConfig;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_ClearFiles;
        private System.Windows.Forms.Button btn_DelFiles;
        private System.Windows.Forms.Button btn_AddFiles;
        private System.Windows.Forms.Label lbl_Monitor;
        private System.Windows.Forms.TextBox txt_Pre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown nud_TaskCount;
        private System.Windows.Forms.Label lbl_ProgessBar;
    }
}

