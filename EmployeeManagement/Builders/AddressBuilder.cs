using EmployeeManagement.Models;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeManagement.Builders
{
    public class AddressBuilder  
    {
        public ApartamentAddress ConstructApartamentAddress(string countryName, string cityName, string streetName, int buildingNumber, int apartamentNumber)
        {
            ApartamentAddress apartamentAddress = new ApartamentAddress();
            apartamentAddress.CountryName = countryName;
            apartamentAddress.CityName = cityName;
            apartamentAddress.StreetName = streetName;
            apartamentAddress.BuildingNumber = buildingNumber;
            apartamentAddress.ApartamentNumber = apartamentNumber;

            return apartamentAddress;
        }

        public HouseAddress ConstructHouseAddress(string countryName, string cityName, string streetName, int houseNumber)
        {
            HouseAddress houseAddress= new HouseAddress();
            houseAddress.CountryName = countryName;
            houseAddress.CityName = cityName;
            houseAddress.StreetName = streetName;
            houseAddress.HouseNumber = houseNumber;

            return houseAddress;
        }
    }
}
