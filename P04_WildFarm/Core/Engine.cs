namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WildFarm.Animals;
    using WildFarm.Animals.Birds;
    using WildFarm.Animals.Mammals;
    using WildFarm.Animals.Mammals.Felines;
    using WildFarm.Foods;

    public class Engine
    {
        private ICollection<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }
        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalInfo = input.Split().ToArray();

                string animalType = animalInfo[0];
                string animalName = animalInfo[1];
                double animalWeight = double.Parse(animalInfo[2]);


                Animal animal = null;
                if (animalType == "Cat" || animalType == "Tiger")
                {
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];

                    if (animalType == "Cat")
                    {
                        animal = new Cat(animalName, animalWeight, livingRegion, breed);
                    }
                    else
                    {
                        animal = new Tiger(animalName, animalWeight, livingRegion, breed);
                    }
                }
                else if (animalType == "Dog" || animalType == "Mouse")
                {
                    string livingRegion = animalInfo[3];
                    if (animalType == "Dog")
                    {
                        animal = new Dog(animalName, animalWeight, livingRegion);
                    }
                    else
                    {
                        animal = new Mouse(animalName, animalWeight, livingRegion);
                    }

                }

                else if (animalType == "Hen" || animalType == "Owl")
                {
                    double wingSize = double.Parse(animalInfo[3]);
                    if (animalType == "Hen")
                    {
                        animal = new Hen(animalName, animalWeight, wingSize);
                    }
                    else
                    {
                        animal = new Owl(animalName, animalWeight, wingSize);
                    }
                    
                }

                animals.Add(animal);

                string[] foodInfo = Console.ReadLine().Split();
                string foodType = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                Food food = null;
                if (foodType == "Vegetable")
                {
                    food = new Vegetable(foodType, foodQuantity);
                }
                else if (foodType == "Meat")
                {
                    food = new Meat(foodType, foodQuantity);
                }
                else if (foodType == "Fruit")
                {
                    food = new Fruit(foodType, foodQuantity);
                }
                else if (foodType == "Seeds")
                {
                    food = new Seeds(foodType, foodQuantity);
                }
                try
                {
                    animal.AskForFood(food)); 
                }
                catch (FoodException ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
