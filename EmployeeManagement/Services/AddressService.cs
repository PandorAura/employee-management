using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using EmployeeManagement.Services.Validators;

namespace EmployeeManagement
{
    public class AddressService
    {
        private AddressBuilder addressBuilder;

        public AddressService(AddressBuilder addressBuilder)
        {
            this.addressBuilder = addressBuilder;
        }

        public Address GetAddress()
        {
            return addressBuilder.GetAddress();
        }

        public void ConstructAddress(string countryName, string cityName, string streetName, int streetNumber, int? houseNumber, int? apartamentBuildingNumber, int? apartamentNumber)
        {
            addressBuilder.WithCountryName(countryName);
            addressBuilder.WithCityName(cityName);
            addressBuilder.WithStreetName(streetName);
            addressBuilder.WithStreetNumber(streetNumber);
            if (houseNumber != null)
            {
                addressBuilder.WithHouseNumber(houseNumber);

            } else
            {
                addressBuilder.WithApartamentBuildingNumber(apartamentBuildingNumber);
                addressBuilder.WithApartamentNumber(apartamentNumber);
            }

            if(!ValidateAddress.IsAddressValid(GetAddress()))
            {
                throw new Exception();
            }
        }
    }
}
