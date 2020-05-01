﻿using System;
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
            ShowObjects = new RelayCommand(p => ShowAction(p as ItemVM), p => p is ItemVM);
        }

        //Команда
        public ICommand FromFirstPage { get; }
        public ICommand BackFirstPage { get; }
        public ICommand BackPage { get; }
        public ICommand NextPage { get; }
        public ICommand ShowObjects { get; }

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

        public void ShowAction(ItemVM item)
        {
            if (item.SelectedCategory.Name == "Жилое помещение")
            {
                if (item.SelectedBuilding.Name == "Квартира")
                {
                    CurrentPage = new ApartmentVM();
                }
            }
            else if (item.SelectedCategory.Name == "Нежилое помещение")
            {
                if (item.SelectedBuilding.Name == "Офисно-торговый объект свободного назначения")
                {
                    MessageBox.Show("Офисно-торговый объект свободного назначения");
                }
                else if (item.SelectedBuilding.Name == "Офисы класса А, В")
                {
                    MessageBox.Show("Офисы класса А, В");
                }
                else if (item.SelectedBuilding.Name == "Торговая недвижимость")
                {
                    MessageBox.Show("Торговая недвижимость");
                }
                else if (item.SelectedBuilding.Name == "Производственно-складская недвижимость")
                {
                    MessageBox.Show("Производственно-складская недвижимость");
                }
            }
            else if (item.SelectedCategory.Name == "Здание")
            {
                if (item.SelectedBuilding.Name == "Жилой дом")
                {
                    MessageBox.Show("Здание! Жилой дом");
                }
                else if (item.SelectedBuilding.Name == "Офисно-торговый объект свободного назначения")
                {
                    MessageBox.Show("Здание! Офисно-торговый объект свободного назначения");
                }
                else if (item.SelectedBuilding.Name == "Офисы класса А, В")
                {
                    MessageBox.Show("Здание! Офисы класса А, В");
                }
                else if (item.SelectedBuilding.Name == "Торговая недвижимость")
                {
                    MessageBox.Show("Здание! Торговая недвижимость");
                }
                else if (item.SelectedBuilding.Name == "Производственно-складская недвижимость")
                {
                    MessageBox.Show("Здание! Производственно-складская недвижимость");
                }
            }
            else if (item.SelectedCategory.Name == "Здание с земельным участком")
            {
                if (item.SelectedBuilding.Name == "Жилой дом")
                {
                    MessageBox.Show("Здание с земельным участком! Жилой дом");
                }
                else if (item.SelectedBuilding.Name == "Офисно-торговый объект свободного назначения")
                {
                    MessageBox.Show("Здание с земельным участком! Офисно-торговый объект свободного назначения");
                }
                else if (item.SelectedBuilding.Name == "Офисы класса А, В")
                {
                    MessageBox.Show("Здание с земельным участком! Офисы класса А, В");
                }
                else if (item.SelectedBuilding.Name == "Торговая недвижимость")
                {
                    MessageBox.Show("Здание с земельным участком! Торговая недвижимость");
                }
                else if (item.SelectedBuilding.Name == "Производственно-складская недвижимость")
                {
                    MessageBox.Show("Здание с земельным участком! Производственно-складская недвижимость");
                }
            }
            else if (item.SelectedCategory.Name == "Земельный участок")
            {
                if (item.SelectedBuilding.Name == "Под индустриальную застройку")
                {
                    MessageBox.Show("Под индустриальную застройку");
                }
                else if (item.SelectedBuilding.Name == "Под офисно-торговую застройку")
                {
                    MessageBox.Show("Под офисно-торговую застройку");
                }
                else if (item.SelectedBuilding.Name == "Под многоквартирную жилую застройку")
                {
                    MessageBox.Show("Под многоквартирную жилую застройку");
                }
                else if (item.SelectedBuilding.Name == "Под индивидуальную жилую застройку")
                {
                    MessageBox.Show("Под индивидуальную жилую застройку");
                }
                else if (item.SelectedBuilding.Name == "Под объекты рекреации")
                {
                    MessageBox.Show("Под объекты рекреации");
                }
                else if (item.SelectedBuilding.Name == "Под объекты придорожного сервиса")
                {
                    MessageBox.Show("Под объекты придорожного сервиса");
                }
            }
            else
            {
                MessageBox.Show("Выберите объект оценки!");
            }
        }
    }
}
