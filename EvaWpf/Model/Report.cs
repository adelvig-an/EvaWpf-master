using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        public DateTime DateVulation { get; set; }
        public DateTime DateCompilation { get; set; }
    }
}
