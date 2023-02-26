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
            address.countryName = countryName;
        }

        public void WithCityName(string cityName)
        {
            address.cityName = cityName;
        }

        public void WithStreetName(string streetName) 
        {
            address.streetName = streetName;
        }

        public void WithStreetNumber(int streetNumber)
        {
            address.streetNumber = streetNumber;
        }

        public void WithHouseNumber(int? houseNumber)
        {
            address.houseNumber = houseNumber;
        }

        public void WithApartamentBuildingNumber(int? apartamentBuildingNumber)
        {
            address.apartamentBuildingNumber = apartamentBuildingNumber;
        }

        public void WithApartamentNumber(int? apartamentNumber)
        {
            address.apartamentNumber = apartamentNumber;
        }

        public Address GetAdress()
        {
            return address;
        }
    }
}
