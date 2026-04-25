using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件监控处理应用.Models {
    public class Config {
        public string MonitorDir { get; set; }
        public string Filters { get; set; }
        public string Rulers { get; set; }
        public string PreText { get; set; }
        public string TargetDir { get; set; }
        public int TaskCount { get; set; }
    }
}
