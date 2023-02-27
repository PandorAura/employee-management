using EmployeeManagement.Models;

namespace EmployeeManagement.Builders
{
    public class AddressBuilder : IAddressBuilder
    {
        private Address address;

        public AddressBuilder()
        {
            address = new Address();
        }

        public AddressBuilder Reset()
        {
            address = new Address();
            return this;
        }

        public void WithCountryName(string countryName)
        {
            address.CountryName = countryName;
        }

        public void WithCityName(string cityName)
        {
            address.CityName = cityName;
        }

        public void WithStreetName(string streetName) 
        {
            address.StreetName = streetName;
        }

        public void WithStreetNumber(int streetNumber)
        {
            address.StreetNumber = streetNumber;
        }

        public void WithHouseNumber(int? houseNumber)
        {
            address.HouseNumber = houseNumber;
        }

        public void WithApartamentBuildingNumber(int? apartamentBuildingNumber)
        {
            address.ApartamentBuildingNumber = apartamentBuildingNumber;
        }

        public void WithApartamentNumber(int? apartamentNumber)
        {
            address.ApartamentNumber = apartamentNumber;
        }

        public Address GetAddress()
        {
            return address;
        }
    }
}
