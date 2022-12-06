using System;
using System.Collections.Generic;
using Demo.Enums;

namespace Demo.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DrivingLicenseCategory> DrivingLicenseCategories { get; set; }
        public bool HasBoatLicense { get; set; }
        public bool IsMillitaryOfficer { get; set; }

        public bool CheckForRequiredDrivingLicenseCategory(DrivingLicenseCategory drivingLicenseCategory)
        {
            foreach (var category in DrivingLicenseCategories)
                if (category == drivingLicenseCategory)
                    return true;

            return false;
        }
    }
}