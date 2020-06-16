using System;
using WildFarm.Enumerators;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const string HAPPY_MOUSE_VOICE = "Squeak";
        private const double WEIGHT_INCREAUSE = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood(Food food)
        {
            Console.WriteLine(HAPPY_MOUSE_VOICE);
            MouseFood mouseFood;
            bool parsed = Enum.TryParse<MouseFood>(food.Type, out mouseFood);

            if (!parsed)
            {
                throw new FoodException(this.GetType().Name, food.Type);
            }

            base.Weight += food.Quantity * WEIGHT_INCREAUSE;
            base.FoodEaten += food.Quantity;
        }
    }
}
