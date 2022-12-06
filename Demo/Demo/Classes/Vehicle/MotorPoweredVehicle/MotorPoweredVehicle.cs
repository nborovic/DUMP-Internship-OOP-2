using System;

namespace Demo.Classes.Vehicle.MotorPoweredVehicle
{
    public abstract class MotorPoweredVehicle : Vehicle { 
        public DateTime RegistrationEndDate { get; private set; }
        public DateTime InsuranceEndDate { get; private set; }
        public static Decimal GasPriceInEuro { get; set; } = 50;
        public string IslandLocation { get; set; }

        protected MotorPoweredVehicle(int yearOfManufacture) : base(yearOfManufacture) { }

        public static void IncreaseGasPriceByPercentage(Decimal percentage)
        {
            GasPriceInEuro += GasPriceInEuro * percentage / 100;
        }

        public bool CheckIsRegistered()
        {
            return RegistrationEndDate > DateTime.Now;
        }

        public bool CheckIsInsured()
        {
            return InsuranceEndDate > DateTime.Now;
        }

        public bool Register()
        {
            if (RegistrationEndDate > DateTime.Now) return false;

            RegistrationEndDate = DateTime.Now.AddYears(1);
            return true;
        }

        public bool Insure(int insuranceDurationInMonths)
        {
            if (InsuranceEndDate > DateTime.Now || RegistrationEndDate <= DateTime.Now) return false;

            InsuranceEndDate = DateTime.Now.AddMonths(insuranceDurationInMonths);
            return true;
        }

        public override string ToString()
        {
            return base.ToString()
                + $"Is registered: {CheckIsRegistered()}\n"
                + $"Is insured: {CheckIsInsured()}\n"
                + $"Island location: {IslandLocation}\n";
        }
    }
}
