using EvaWpf.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.VM
{
    public class FirstPageVM : PageVM
    {
        public FirstPageVM()
        {
            Report = new Report
            {
                Number = 001
            };

            DocsFoundation = new DocsFoundation
            {
                Number = "001/ОЦ"
            };
        }

        public Report Report { get; }
        public DocsFoundation DocsFoundation { get; }

        public IEnumerable<string> TypeCosts { get; }
        public IEnumerable<string> Appraisers { get; }
    }
}
