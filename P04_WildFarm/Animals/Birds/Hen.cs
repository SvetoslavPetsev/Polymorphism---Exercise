using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        private const string HAPPY_HEN_VOICE = "Cluck";
        private const double WEIGHT_INCREAUSE = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void AskForFood(Food food)
        {
            System.Console.WriteLine(HAPPY_HEN_VOICE);
            base.Weight += food.Quantity * WEIGHT_INCREAUSE;
            base.FoodEaten += food.Quantity;
        }
    }
}
