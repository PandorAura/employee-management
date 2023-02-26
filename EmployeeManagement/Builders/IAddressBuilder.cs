using EmployeeManagement.Models;

namespace EmployeeManagement.Builders
{
    public interface IAddressBuilder
    {
        public void WithCountryName(string countryName);
        public void WithCityName(string cityName);
        public void WithStreetName(string streetName);
        public void WithStreetNumber(int streetNumber);
        public void WithHouseNumber(int? houseNumber);
        public void WithApartamentBuildingNumber(int? apartamentBuildingNumber);
        public void WithApartamentNumber(int? apartamentNumber);
        public AddressBuilder Reset();
        public Address GetAdress();
    }
}
