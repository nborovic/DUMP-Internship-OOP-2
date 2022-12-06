namespace Demo.Classes.Vehicle.HumanPoweredVehicle
{
    public abstract class HumanPoweredVehicle : Vehicle
    {
        protected HumanPoweredVehicle(int yearOfManufacture) : base(yearOfManufacture) { }
    
        public override bool ChangeOwner(Person newOwner)
        {
            Owner = newOwner;
            return true;
        }
    }
}
