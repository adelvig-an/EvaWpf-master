using System;
using System.Collections.Generic;

namespace EvaWpf.Model
{
    public class Category
    {
        public string Name { get; set; }
        public List<BuildingBase> Items { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
