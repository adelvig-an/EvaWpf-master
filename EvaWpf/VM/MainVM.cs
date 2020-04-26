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
            BackPage = new RelayCommand(_ => BackPageAction());
            NextPage = new RelayCommand(_ => NextPageAction());
        }

        //Команда
        public ICommand FromFirstPage { get; }
        public ICommand BackFirstPage { get; }
        public ICommand BackPage { get; }
        public ICommand NextPage { get; }
        
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

        public void BackPageAction()
        {
            if (CurrentPage is PrivatePersonVM || CurrentPage is OrganizationVM)
            {
                CurrentPage = new FirstPageVM();
            }
        }

        public void NextPageAction()
        {
            if (CurrentPage is PrivatePersonVM || CurrentPage is OrganizationVM)
            {
                CurrentPage = new TypeObjectsVM();
            }
        }
    }
}
