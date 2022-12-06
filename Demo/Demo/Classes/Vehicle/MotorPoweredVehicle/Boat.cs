using Demo.Interfaces;

namespace Demo.Classes.Vehicle.MotorPoweredVehicle
{
    public sealed class Boat : MotorPoweredVehicle, IMoveableOnWater
    {
        public string PortLocation { get; set; }
        public Boat(int yearOfManufacture) : base(yearOfManufacture) { }

        public override bool ChangeOwner(Person newOwner)
        {
            if (!newOwner.HasBoatLicense) return false;

            Owner = newOwner;
            return true;
        }

        public void MoveOnWater(string newIsland, string newPort) 
        {
            IslandLocation = newIsland;
            PortLocation = newPort;
        }

        public override string ToString()
        {
            return base.ToString()
                + $"Port location: {PortLocation}";
        }
    }
}
