    using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Position { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Docs { get; set; }
        public string SerialDocs { get; set; }
        public int NumberDocs { get; set; }
        public string IssuedDocs { get; set; }
        public DateTime DateDocs { get; set; }
        public string CodeDocs { get; set; }
        public string FormOrganization { get; set; }
        public string NameOrganization { get; set; }
        public long OGRN { get; set; }
        public DateTime DateOrganization { get; set; }
        public uint INN { get; set; }
        public int KPP { get; set; }
        public int PaymentAccount { get; set; }
        public string NameBank { get; set; }
        public int BIK { get; set; }
        public string AddressReg { get; set; }
        public int IndexReg { get; set; }
        public string CountryReg { get; set; }
        public string RegionReg { get; set; }
        public string DistrictReg { get; set; }
        public string CityReg { get; set; }
        public string StreetReg { get; set; }
        public string NumberHouseReg { get; set; }
        public int NumberRoomReg { get; set; }
        public string AddressActual { get; set; }
        public int IndexActual { get; set; }
        public string CountryActual { get; set; }
        public string RegionActual { get; set; }
        public string DistrictActual { get; set; }
        public string CityActual { get; set; }
        public string StreetActual { get; set; }
        public string NumberHouseActual { get; set; }
        public int NumberRoomActual { get; set; }
    }
}
