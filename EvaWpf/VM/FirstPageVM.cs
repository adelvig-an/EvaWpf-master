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

        }
        

        Report report = new Report
        {
            Number = 001
        };

        //DocsFoundation foundation = new DocsFoundation 
        //{
        //    Number = "001/ОЦ"
        //};
    }
}
