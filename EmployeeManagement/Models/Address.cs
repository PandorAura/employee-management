using System.ComponentModel;

namespace EmployeeManagement.Models
{
    public class Address
    {
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }

        public virtual string DisplayAddress()
        {
            return $"{CountryName}, {CityName}, {StreetName}";
        }
    }
}
