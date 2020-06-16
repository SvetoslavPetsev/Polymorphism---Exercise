namespace WildFarm.Animals.Mammals
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        protected string Breed { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{base.Name}, {this.Breed}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
