using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    class Appraiser
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Experience { get; set; }
        public string SRO { get; set; }
        public string DateSRO { get; set; }
        public string Diplom { get; set; }
        public int NumberDiplom { get; set; }
        public DateTime DateDiplom { get; set; }
        public string Insurance { get; set; }
        public string NumberInsurance { get; set; }
        public int SumInsurance { get; set; }
        public DateTime DateFromInsurance { get; set; }
        public DateTime DetaBeforeInsurance { get; set; }
        public int NumberQCR { get; set; }
        public DateTime DateFromQCR { get; set; }
        public DateTime DateBeforeQCR { get; set; }
        public int NumberQCM { get; set; }
        public DateTime DateFromQCM { get; set; }
        public DateTime DateBeforeQCM { get; set; }
        public int NumberQCB { get; set; }
        public DateTime DateFromQCB { get; set; }
        public DateTime DateBeforeQCB { get; set; }
    }
}
