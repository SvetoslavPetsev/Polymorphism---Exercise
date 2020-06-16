namespace WildFarm.Animals.Mammals.Felines
{
    using System;
    using WildFarm.Enumerators;
    using WildFarm.Foods;

    public class Cat : Feline
    {
        private const string HAPPY_CAT_VOICE = "Meow";
        private const double WEIGHT_INCREAUSE = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood(Food food)
        {
            Console.WriteLine(HAPPY_CAT_VOICE);
            CatFood catFood;
            bool parsed = Enum.TryParse<CatFood>(food.Type, out catFood);
            if (!parsed)
            {
                throw new FoodException(this.GetType().Name, food.Type);
            }
            base.Weight += food.Quantity * WEIGHT_INCREAUSE;
            base.FoodEaten += food.Quantity;
        }
    }
}
