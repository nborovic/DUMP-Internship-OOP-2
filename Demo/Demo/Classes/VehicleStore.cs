using System;
using System.Collections.Generic;
using Demo.Interfaces;

namespace Demo.Classes
{
    public static class VehicleStore
    {
        public static List<Vehicle.Vehicle> Vehicles { get; } = new List<Vehicle.Vehicle>();
    
        public static void MoveAllLandVehiclesToCity(string newCity)
        {
            foreach (var vehicle in Vehicles)
            {
                var landVehicle = vehicle as IMoveableOnLand;
                
                if (landVehicle != null) 
                    landVehicle.MoveOnLand(newCity);
            }
        }

        public static void MoveAllWaterVehiclesToIslandPort(string newIsland, string newPort)
        {
            foreach (var vehicle in Vehicles)
            {
                if (vehicle is IMoveableOnWater waterVehicle) 
                    waterVehicle.MoveOnWater(newIsland, newPort);
            }
        }

        public static void PrintVehicles()
        {
            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"{vehicle}\n");
            }
        }

        public static void Add(Vehicle.Vehicle newVehicle)
        {
            Vehicles.Add(newVehicle);
        }

        public static bool Remove(Guid vehicleId)
        {
            foreach (var vehicle in Vehicles)
            {
                if (vehicle.Id == vehicleId)
                {
                    Vehicles.Remove(vehicle);
                    return true;
                }
            }

            return false;
        }
    }
}
