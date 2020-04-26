using EvaWpf.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.VM
{
    class PrivatePersonVM : PageVM
    {
        private bool isAddressMatch;
        public Customer Customer { get; set; }
        public IEnumerable<string> TypeDocs { get; }
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
                    Customer.AddressActual = "660000, Красноярский край, Боготольский район, г. Боготол, улица Чайковского, дом 12, квартира 45";
                    Customer.IndexActual = 663091;
                    Customer.CountryActual = "Российская Федерация";
                    Customer.RegionActual = "Красноярский";
                    Customer.DistrictActual = "Боготольский";
                    Customer.CityActual = "Боготол";
                    Customer.StreetActual = "Чайковского";
                    Customer.NumberHouseActual = "12";
                    Customer.NumberRoomActual = 45;
                }
                OnPropertyChanged(nameof(Customer));
            }
        }

        public PrivatePersonVM()
        {
            Customer = new Customer
            {
                SurName = "Иванов",
                FirstName = "Петр",
                LastName = "Сергеевич",
                SerialDocs = "04 00",
                NumberDocs = 151456,
                IssuedDocs = "ОТДЕЛОМ УФМС РОССИИ ПО КРАСНОЯРСКОМУ КРАЮ В СОВЕТСКОМ РАЙОНЕ Г. КРАСНОЯРСКА",
                DateDocs = new DateTime(2017, 05, 25),
                CodeDocs = "240-003",

                AddressReg = "660094, Красноярский край, город Красноярск, улица Мичурина, дом 20, квартира 15",
                IndexReg = 660094,
                CountryReg = "Российская Федерация",
                RegionReg = "Красноярский",
                DistrictReg = "Какой-то район",
                CityReg = "Красноярск",
                StreetReg = "Мичурина",
                NumberHouseReg = "20",
                NumberRoomReg = 15,

                AddressActual = "660000, Красноярский край, Боготольский район, г. Боготол, улица Чайковского, дом 12, квартира 45",
                IndexActual = 663091,
                CountryActual = "Российская Федерация",
                RegionActual = "Красноярский",
                DistrictActual = "Боготольский",
                CityActual = "Боготол",
                StreetActual = "Чайковского",
                NumberHouseActual = "12",
                NumberRoomActual = 45
            };

            TypeDocs = LocalStorage.TypeDocs;
        }
    }
}
