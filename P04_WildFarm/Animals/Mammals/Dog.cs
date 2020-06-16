namespace WildFarm.Animals.Mammals
{
    using System;
    using WildFarm.Enumerators;
    using WildFarm.Foods;

    public class Dog : Mammal
    {
        private const string HAPPY_DOG_VOICE = "Woof!";
        private const double WEIGHT_INCREAUSE = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood(Food food)
        {
            Console.WriteLine(HAPPY_DOG_VOICE);
            DogFood dogFood;
            bool parsed = Enum.TryParse<DogFood>(food.Type, out dogFood);
            if (!parsed)
            {
                throw new FoodException(this.GetType().Name, food.Type);
            }
            base.Weight += food.Quantity * WEIGHT_INCREAUSE;
            base.FoodEaten += food.Quantity;
        }
    }
}
