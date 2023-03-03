namespace EmployeeManagement.Models
{
    public class ApartamentAddress : Address
    {
        public int BuildingNumber { get; set; }
        public int ApartamentNumber { get; set; }

        public override string DisplayAddress()
        {
            return $"{CountryName}, {CityName}, {StreetName}, {BuildingNumber}, {ApartamentNumber}";
        }
    }
}
