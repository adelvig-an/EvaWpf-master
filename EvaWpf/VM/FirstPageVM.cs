using EvaWpf.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.VM
{
    class FirstPageVM : PageVM
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

        Report Report { get; }
        DocsFoundation DocsFoundation { get; }
    }
}
