using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    public class Perormer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int OGRN { get; set; }
        public int INN { get; set; }
        public int KPP { get; set; }
        public string Insurance { get; set; }
        public string Number { get; set; }
        public int SumInsurance { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DetaBefore { get; set; }
        public string Address { get; set; }
    }
}
