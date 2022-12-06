using System;
using System.Collections.Generic;
using Demo.Classes;
using Demo.Enums;
using Demo.Classes.Vehicle.MotorPoweredVehicle;

namespace Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var car = new Car(2004)
            {
                Manufacturer = "Renault",
                Model = "Megane",
                IslandLocation = "Brac",
                Owner = new Person()
                {
                    FirstName = "Mate",
                    LastName = "Matic",
                    DateOfBirth = new DateTime(2000, 3, 15),
                    DrivingLicenseCategories = new List<DrivingLicenseCategory>()
                    {
                        DrivingLicenseCategory.A,
                        DrivingLicenseCategory.A1,
                        DrivingLicenseCategory.B
                    },
                    HasBoatLicense = true,
                    IsMillitaryOfficer = true,
                }
            };

            var amphibia = new Amphibia(2004)
            {
                Manufacturer = "Amphibia",
                Model = "Model Y",
                IslandLocation = "Brac",
                Owner = new Person()
                {
                    FirstName = "Mate",
                    LastName = "Matic",
                    DateOfBirth = new DateTime(2000, 3, 15),
                    DrivingLicenseCategories = new List<DrivingLicenseCategory>()
                    {
                        DrivingLicenseCategory.A,
                        DrivingLicenseCategory.A1,
                        DrivingLicenseCategory.B
                    },
                    HasBoatLicense = true,
                    IsMillitaryOfficer = true,
                }
            };

            var boat = new Boat(2005)
            {
                Manufacturer = "Boat",
                Model = "Model X",
                IslandLocation = "Brac",
                Owner = new Person()
                {
                    FirstName = "Sime",
                    LastName = "Simic",
                    DateOfBirth = new DateTime(2001, 3, 15),
                    DrivingLicenseCategories = new List<DrivingLicenseCategory>()
                    {
                        DrivingLicenseCategory.A,
                        DrivingLicenseCategory.A1,
                        DrivingLicenseCategory.B
                    },
                    HasBoatLicense = true,
                    IsMillitaryOfficer = false,
                }
            };
            
            VehicleStore.Add(car);
            VehicleStore.Add(amphibia);
            VehicleStore.Add(boat);
            
            VehicleStore.MoveAllLandVehiclesToCity("Bol");
            
            VehicleStore.PrintVehicles();
            
            VehicleStore.MoveAllWaterVehiclesToIslandPort("Pag", "Pag");
            
            VehicleStore.PrintVehicles();

            Console.ReadLine();
        }
    }
}