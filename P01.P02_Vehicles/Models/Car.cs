namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double CLIMA_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double litersPerKilometer, double tankCapacity)
            :base(fuelQuantity, litersPerKilometer, tankCapacity)
        {
            base.ClimaConsuption = CLIMA_CONSUMPTION;
        }
    }
}
