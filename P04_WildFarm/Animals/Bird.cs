namespace WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        protected double WingSize { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{base.Name}, {this.WingSize}, {base.Weight}, {base.FoodEaten}]";
        }
    }
}
