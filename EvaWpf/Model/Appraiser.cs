using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    class Appraiser
    {
        public int AppraiserId { get; set; }
        public string SurNameAppraiser { get; set; }
        public string FirstNameAppraiser { get; set; }
        public string LastNameAppraiser { get; set; }
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
        public int NumberQualificationCertificateRealty { get; set; }
        public DateTime DateFromQualificationCertificateRealty { get; set; }
        public DateTime DateBeforeQualificationCertificateRealty { get; set; }
        public int NumberQualificationCertificateMovable { get; set; }
        public DateTime DateFromQualificationCertificateMovable { get; set; }
        public DateTime DateBeforeQualificationCertificateMovable { get; set; }
        public int NumberQualificationCertificateBussines { get; set; }
        public DateTime DateFromQualificationCertificateBussines { get; set; }
        public DateTime DateBeforeQualificationCertificateBussines { get; set; }
        public string AddressAppraiser { get; set; }
    }
}
