namespace FR.DomainModel
{
    public class Recipe : Entity
    {
        public virtual string Name { get; set; }
        public virtual double Stars { get; set; }
        public virtual string Description { get; set; }
    }
}
