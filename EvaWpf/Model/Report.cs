using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    class Report
    {
        public int ReportId { get; set; }
        public string TitleReport { get; set; }
        public int NumberReport { get; set; }
        public DateTime DateVulation { get; set; }
        public DateTime DateCompilation { get; set; }
    }
}
