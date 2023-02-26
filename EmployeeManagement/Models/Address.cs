using System.ComponentModel;

namespace EmployeeManagement.Models
{
    public class Address
    {
        public int MyProperty { get; set; }
        public int streetNumber { get; set; }
        public int? houseNumber { get; set; }
        public int? apartamentBuildingNumber { get; set; }
        public int? apartamentNumber { get; set; }
        public string streetName { get; set; }
        public string cityName { get; set; }
        public string countryName { get; set; }
    }
}
