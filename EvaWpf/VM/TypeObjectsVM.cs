using EvaWpf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EvaWpf.VM
{
    public class TypeObjectsVM : PageVM
    {
        public TypeObjectsVM()
        {
            AddCommand = new RelayCommand(_ => Add());
            ShowCommand = new RelayCommand(p => Show(p as ItemVM), p => p is ItemVM);
            Items = new ObservableCollection<ItemVM>();
            Categories = ListBuilding.Categories;
        }

        

        public void Add()
        {
            Items.Add(new ItemVM(nameof(ButtonContent)));
        }

        public void Show(ItemVM item)
        {
            // Это нарушает MVVM и в реальном проекте так делать нельзя
            // но поскольку это демонстрационный пример 
            // выводим просто сообщение
            System.Windows.MessageBox.Show($"Info: {item?.SelectedBuilding}");
        }

        public IEnumerable<Category> Categories { get; }

        public ICommand AddCommand { get; }

        public ICommand ShowCommand { get; }

        public ObservableCollection<ItemVM> Items { get; }
        
        private int n = 1;
        public string ButtonContent 
        { 
            get => ButtonContent; 
            set
            {
                ButtonContent = "Описание объекта" + n;
                n++;
            }
        }

    }
}
