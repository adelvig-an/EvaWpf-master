using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EvaWpf.VM
{
    class ApartmentVM : PageVM
    {
        public IEnumerable<string> TehDocuments { get; set; }

        public ICommand AddCommand { get; }
    }
}
