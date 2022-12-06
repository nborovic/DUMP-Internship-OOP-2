using System;

namespace Demo.Classes.Vehicle
{
    public abstract class Vehicle
    {
        public Guid Id { get; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; }
        public Person Owner { get; set; }

        protected Vehicle(int yearOfManufacture)
        {
            Id = Guid.NewGuid();
            YearOfManufacture = yearOfManufacture;
        }

        public abstract bool ChangeOwner(Person newOwner);

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}\n"
                + $"Model: {Model}\n"
                + $"Owner: {Owner.FirstName} {Owner.LastName}\n";
        }
    }
}
