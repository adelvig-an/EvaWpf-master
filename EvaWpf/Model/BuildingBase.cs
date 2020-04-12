namespace EvaWpf.Model
{
    public abstract class BuildingBase
    {
        public string Name { get; }
        protected BuildingBase(string name) =>
            Name = name;
        public override string ToString() => Name;
    }
}
