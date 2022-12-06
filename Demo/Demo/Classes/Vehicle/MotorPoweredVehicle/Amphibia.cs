using Demo.Interfaces;
using Demo.Enums;

namespace Demo.Classes.Vehicle.MotorPoweredVehicle
{
    public sealed class Amphibia : MotorPoweredVehicle, IMoveableOnLand, IMoveableOnWater
    {
        public string CityLocation { get; set; }
        public string PortLocation { get; set; }
        public Amphibia(int yearOfManufacture) : base(yearOfManufacture) { }

        public override bool ChangeOwner(Person newOwner)
        {
            if (!newOwner.CheckForRequiredDrivingLicenseCategory(DrivingLicenseCategory.B) 
                || !newOwner.HasBoatLicense
                || !newOwner.IsMillitaryOfficer) return false;

            Owner = newOwner;
            return true;
        }

        public void MoveOnLand(string newCity)
        {
            CityLocation = newCity;
            PortLocation = null;
        }

        public void MoveOnWater(string newIsland, string newPort)
        {
            IslandLocation = newIsland;
            PortLocation = newPort;
            CityLocation = null;
        }

        public override string ToString()
        {
            return base.ToString()
                + $"Port location: {PortLocation}\n"
                + $"City location: {CityLocation}";
        }
    }
}
