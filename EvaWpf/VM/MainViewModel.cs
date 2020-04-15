using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.VM
{
    public class MainViewModel : ViewModelBase
    {
        private PageVM currentPage;
        public PageVM CurrentPage
        {
            get => currentPage;
            set => SetProperty(ref currentPage, value);
        }

        public MainViewModel()
        {
            CurrentPage = new FirstPageVM();
        }
    }
}
