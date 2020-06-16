namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Vehicles.Models;

    public class Engine
    {
        private ICollection<Vehicle> vehicleList;
        public Engine()
        {
            this.vehicleList = new List<Vehicle>();
        }

        public void Run()
        {
            for (int i = 0; i < 3; i++)
            {
                string[] info = Console.ReadLine().Split().ToArray();
                string vehicleType = info[0];
                double fuelQuantity = double.Parse(info[1]);
                double fuelConsumption = double.Parse(info[2]);
                double tankCapacity = double.Parse(info[3]);

                Vehicle vehicle = null;

                if (vehicleType == "Car")
                {
                    vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else if (vehicleType == "Truck")
                {
                    vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else if (vehicleType == "Bus")
                {
                    vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                }
                vehicleList.Add(vehicle);
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split().ToArray();
                string command = cmdArg[0];
                string type = cmdArg[1];

                Vehicle selectedVehicle = vehicleList.FirstOrDefault(x => x.GetType().Name == type);
                selectedVehicle.AirConditioningController = AirConditioningController.ON;

                try
                {
                    if (command == "Drive")
                    {
                        double distance = double.Parse(cmdArg[2]);

                        selectedVehicle.Drive(distance);
                        Console.WriteLine($"{selectedVehicle.GetType().Name} travelled {distance} km");
                    }

                    else if (command == "DriveEmpty")
                    {
                        double distance = double.Parse(cmdArg[2]);

                        selectedVehicle.AirConditioningController = AirConditioningController.OFF;
                        selectedVehicle.Drive(distance);
                        Console.WriteLine($"{selectedVehicle.GetType().Name} travelled {distance} km");
                    }

                    else if (command == "Refuel")
                    {
                        double fuel = double.Parse(cmdArg[2]);
                        selectedVehicle.Refuel(fuel);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

            }

            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
