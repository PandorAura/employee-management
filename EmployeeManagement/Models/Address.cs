using System.ComponentModel;

namespace EmployeeManagement.Models
{
    // Create HouseAddress and ApartmentAddress extending Address (abstract class)
    public abstract class Address
    {
        public int StreetNumber { get; set; }
        public int? HouseNumber { get; set; }
        public int? ApartamentBuildingNumber { get; set; }
        public int? ApartamentNumber { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
    }
}
