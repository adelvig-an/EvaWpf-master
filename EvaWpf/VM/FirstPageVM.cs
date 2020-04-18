using EvaWpf.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.VM
{
    public class FirstPageVM : PageVM
    {
        public Report Report { get; }
        public DocsFoundation DocsFoundation { get; }

        public IEnumerable<string> TypeCosts { get; }
        public IEnumerable<string> Appraisers { get; }
        public bool IsPrivatePerson { get; set; }
        public bool IsOrganization { get; set; }

        public FirstPageVM()
        {
            Report = new Report
            {
                Number = 001,
                DateVulation = new DateTime(2019, 04, 15),
                DateCompilation = new DateTime (2019, 04, 30)
            };

            DocsFoundation = new DocsFoundation
            {
                Number = "001/ОЦ",
                DateFoundation = new DateTime (2019, 03, 01),
                Target = "Определение рыночной стоимости"
            };

            TypeCosts = LocalStorage.TypeCosts;
            Appraisers = LocalStorage.Appraisers;
        }
    }
}
