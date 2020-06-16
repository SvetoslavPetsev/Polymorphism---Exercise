namespace WildFarm.Animals.Birds
{
    using System;
    using WildFarm.Enumerators;
    using WildFarm.Foods;

    public class Owl : Bird
    {
        private const string HAPPY_OWL_VOICE = "Hoot Hoot";
        private const double WEIGHT_INCREAUSE = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void AskForFood(Food food)
        {
            Console.WriteLine(HAPPY_OWL_VOICE);
            OwlFood owlFood;
            bool parsed = Enum.TryParse(food.Type,out owlFood);

            if (!parsed)
            {
                throw new FoodException(this.GetType().Name, food.Type);
            }
            base.Weight += food.Quantity * WEIGHT_INCREAUSE;
            base.FoodEaten += food.Quantity;
        }
    }
}
