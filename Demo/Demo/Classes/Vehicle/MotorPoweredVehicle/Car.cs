using Demo.Enums;
using Demo.Interfaces;

namespace Demo.Classes.Vehicle.MotorPoweredVehicle
{
    public class Car : MotorPoweredVehicle, IMoveableOnLand
    {
        public string CityLocation { get; set; }

        public Car(int yearOfManufacture) : base(yearOfManufacture) { }

        public sealed override bool ChangeOwner(Person newOwner)
        {
            if (!newOwner.CheckForRequiredDrivingLicenseCategory(DrivingLicenseCategory.B)) return false;

            Owner = newOwner;
            return true;
        }
        
        public void MoveOnLand(string newCity)
        {
            CityLocation = newCity;
        }
        public override string ToString()
        {
            return base.ToString()
                + $"City location: {CityLocation}";
        }
    }
}