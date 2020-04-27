using EvaWpf.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace EvaWpf.VM
{
    public class OrganizationVM : PageVM
    {
        private bool isAddressMatch;
        public Customer Customer { get; set; }
        public IEnumerable<string> FormOrganizations { get; }
        public IEnumerable<string> TypeDocsPos { get; }
        public bool IsAddressMatch
        {
            get => isAddressMatch;
            set
            {
                SetProperty(ref isAddressMatch, value);
                if (value == true)
                {
                    Customer.AddressActual = Customer.AddressReg;
                    Customer.IndexActual = Customer.IndexReg;
                    Customer.CountryActual = Customer.CountryReg;
                    Customer.RegionActual = Customer.RegionReg;
                    Customer.DistrictActual = Customer.DistrictReg;
                    Customer.CityActual = Customer.CityReg;
                    Customer.StreetActual = Customer.StreetReg;
                    Customer.NumberHouseActual = Customer.NumberHouseReg;
                    Customer.NumberRoomActual = Customer.NumberRoomReg;
                }
                else
                {
                    Customer.AddressActual = "663091, Красноярский край, Шарыповский район, г. Шарыпово, улица Бочкина, дом 50, помещение 10";
                    Customer.IndexActual = 663091;
                    Customer.CountryActual = "Российская Федерация";
                    Customer.RegionActual = "Красноярский";
                    Customer.DistrictActual = "Шарыповский";
                    Customer.CityActual = "Шарыпово";
                    Customer.StreetActual = "Бочкина";
                    Customer.NumberHouseActual = "50";
                    Customer.NumberRoomActual = 10;
                }
                OnPropertyChanged(nameof(Customer));
            }
        }

        public OrganizationVM()
        {
            Customer = new Customer
            {
                NameOrganization = "НЭО Структура",
                INN = 2461045705,
                KPP = 246101001,
                OGRN = 1202400004047,
                DateOrganization = new DateTime(2020, 02, 18),

                Position = "Директор",
                SurName = "Иванов",
                FirstName = "Петр",
                LastName = "Сергеевич",
                SerialDocs = "12 АК",
                NumberDocs = 151,
                DateDocs = new DateTime(2019, 01, 10),

                AddressReg = "660094, Красноярский край, город Красноярск, улица Щорса, дом 34В, офис 5",
                IndexReg = 660094,
                CountryReg = "Российская Федерация",
                RegionReg = "Красноярский",
                DistrictReg = "",
                CityReg = "Красноярск",
                StreetReg = "Щорса",
                NumberHouseReg = "34В",
                NumberRoomReg = 5,

                AddressActual = "663091, Красноярский край, Шарыповский район, г. Шарыпово, улица Бочкина, дом 50, помещение 10",
                IndexActual = 663091,
                CountryActual = "Российская Федерация",
                RegionActual = "Красноярский",
                DistrictActual = "Шарыповский",
                CityActual = "Шарыпово",
                StreetActual = "Бочкина",
                NumberHouseActual = "50",
                NumberRoomActual = 10
            };

            FormOrganizations = LocalStorage.FormOrganizations;
            TypeDocsPos = LocalStorage.TypeDocsPos;
        }

    }
}
