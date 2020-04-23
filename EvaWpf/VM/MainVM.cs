using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace EvaWpf.VM
{
    public class MainVM : ViewModelBase
    {
        private PageVM currentPage;
        public PageVM CurrentPage
        {
            get => currentPage;
            set => SetProperty(ref currentPage, value);
        }

        public MainVM()
        {
            CurrentPage = new FirstPageVM();
            FromFirstPage = new RelayCommand(_ => FromFirstPageAction());
        }

        //Команда
        public ICommand FromFirstPage { get; }
        
        //Условие RadioButton для Button
        public void FromFirstPageAction() 
        { 
            if (CurrentPage is FirstPageVM firstPage) 
            {
                if (firstPage.IsPrivatePerson)
                {
                    CurrentPage = new PrivatePersonVM();
                }
                else if (firstPage.IsOrganization)
                { 
                    CurrentPage = new OrganizationVM(); 
                }
                else
                {
                    MessageBox.Show("Выберите Тип клиента!");
                }
            } 
        }

        public void FormAddressMatch()
        {
            
        }

    }
}
