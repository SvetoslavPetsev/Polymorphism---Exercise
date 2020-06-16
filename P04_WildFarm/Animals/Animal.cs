using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }
        protected string Name { get; set; }
        protected double Weight { get; set; }
        protected int FoodEaten { get; set; }


        public abstract void AskForFood(Food food);
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
