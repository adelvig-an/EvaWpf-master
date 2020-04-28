using EvaWpf.Model;

namespace EvaWpf.VM
{
    public class ItemVM : ViewModelBase
    {
        public ItemVM(string v)
        {
        }

        public Category SelectedCategory { get; set; }

        public BuildingBase SelectedBuilding { get; set; }
    }
}
