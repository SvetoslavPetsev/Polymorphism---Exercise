namespace Vehicles.Models
{
    using System;
    public class Vehicle
    {
        private double fuelQuantity;
        
        public Vehicle(double fuelQuantity, double litersPerKilometer, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.LitersPerKilometer = litersPerKilometer;
            this.AirConditioningController = AirConditioningController.ON;
            this.PipeCondition = 1;
        }

        public AirConditioningController AirConditioningController { get; set; }
        protected double PipeCondition { get; set; }
        protected double FuelQuantity 
        { 
            get 
            {
                return this.fuelQuantity;
            } 
            private set 
            {
                if (this.TankCapacity < value)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            } 
        }

        protected double LitersPerKilometer { get; set; }

        protected double TankCapacity { get; set; }

        public double ClimaConsuption { get; set; }

        public void Drive(double distance)
        {
            double consumption = GetConsumption();

            double neededFuel = distance * consumption;
            if (neededFuel > this.FuelQuantity)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= neededFuel;
        }

        private double GetConsumption()
        {
            double consumption;
            if (this.AirConditioningController == AirConditioningController.ON)
            {
                consumption = this.LitersPerKilometer + this.ClimaConsuption;
            }
            else
            {
                consumption = this.LitersPerKilometer;
            }

            return consumption;
        }

        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            else if (fuel + this.FuelQuantity > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }
            this.FuelQuantity += fuel * this.PipeCondition;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
