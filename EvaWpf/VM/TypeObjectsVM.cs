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
            Items = new ObservableCollection<ItemVM>();
            Categories = ListBuilding.Categories;
        }

        public int n = 1;
        public void Add()
        {
            Items.Add(new ItemVM("Описание объекта " + n));
            n++;
        }

        public IEnumerable<Category> Categories { get; }

        public ICommand AddCommand { get; }

        public ObservableCollection<ItemVM> Items { get; }
    }
}
