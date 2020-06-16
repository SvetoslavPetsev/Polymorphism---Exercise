namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double CLIMA_CONSUMPTION = 1.6;
        private const double RESERVOUR_PIPE_CONDITION = 0.95;

        public Truck(double fuelQuantity, double litersPerKilometer, double tankCapacity)
            : base(fuelQuantity, litersPerKilometer, tankCapacity)
        {
            base.ClimaConsuption = CLIMA_CONSUMPTION;
            base.PipeCondition = RESERVOUR_PIPE_CONDITION;
        }
    }
}
