using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件监控处理应用.Models {
    public class FileTask :INotifyPropertyChanged{
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long FileSizeBytes { get; set; }
        private FileStatus _status = FileStatus.等待中;

        public FileStatus Status {
            get { return _status; }
            set {
                _status = value;
                OnPropertyChangen("Status");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChangen(string Name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }

        public string FileSize {
            get {
                if (FileSizeBytes < 1024) return $"{FileSizeBytes} B";
                if (FileSizeBytes < 1024 * 1024) return $"{FileSizeBytes / 1024.0:F1} KB";
                if (FileSizeBytes < 1024 * 1024 * 1024) return $"{FileSizeBytes / (1024.0 * 1024.0):F1} MB";
                return $"{FileSizeBytes / (1024.0 * 1024.0 * 1024.0):F1} GB";
            }
        }


    }

    public enum FileStatus {
        等待中,
        处理中,
        已完成,
        处理失败,
        已取消
    }
}
