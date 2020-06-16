using System.Net.WebSockets;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double CLIMA_CONSUMPTION = 1.4;

        public Bus(double fuelQuantity, double litersPerKilometer, double tankCapacity) 
            : base(fuelQuantity, litersPerKilometer, tankCapacity)
        {
            base.ClimaConsuption = CLIMA_CONSUMPTION;
        }
    }
}
