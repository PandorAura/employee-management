namespace EmployeeManagement.Models
{
    public class HouseAddress : Address
    {
        public int HouseNumber { get; set; }

        public override string DisplayAddress()
        {
            return $"{CountryName}, {CityName}, {StreetName}, {HouseNumber}";
        }
    }
}
