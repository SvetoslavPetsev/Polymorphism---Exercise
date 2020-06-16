namespace WildFarm.Animals.Mammals.Felines
{
    using System;
    using WildFarm.Enumerators;
    using WildFarm.Foods;

    public class Tiger : Feline
    {
        private const string HAPPY_TIGER_VOICE = "ROAR!!!";
        private const double WEIGHT_INCREAUSE = 1;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood(Food food)
        {
            Console.WriteLine(HAPPY_TIGER_VOICE);
            TigerFood tigerFood;
            bool parsed = Enum.TryParse<TigerFood>(food.Type, out tigerFood);
            if (!parsed)
            {
                throw new FoodException(this.GetType().Name, food.Type);
            }
            base.Weight += food.Quantity * WEIGHT_INCREAUSE;
            base.FoodEaten += food.Quantity;
        }
    }
}
