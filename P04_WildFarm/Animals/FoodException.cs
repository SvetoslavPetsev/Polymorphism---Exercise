namespace WildFarm.Animals
{
    using System;

    public class FoodException : Exception
    {
        public FoodException(string animalType, string food)
            : base($"{animalType} does not eat {food}!")
        {
        }

        public FoodException(string message) 
            : base(message)
        {
        }
    }
}
