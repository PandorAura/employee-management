using EmployeeManagement.Builders;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
   
    public class CreateAddressService
    {
        string countryName, streetName, cityName;
        int houseNumber, streetNumber, apartamentBuildingNumber, apartamentNumber;

        public Address CreateAddress()
        {
            AddressBuilder addressBuilder = new AddressBuilder();
            AddressService addressService = new AddressService(addressBuilder);

            Console.WriteLine("Is the person living in a house? ");
            bool isLivingInAHouse = bool.Parse(Console.ReadLine());
            Console.WriteLine("The address is: ");
            AddressReader addressReader = new AddressReader();

            if (isLivingInAHouse)
            {
                countryName = addressReader.ReadCountryName();
                cityName = addressReader.ReadCityName();
                streetName = addressReader.ReadStreetName();
                houseNumber = addressReader.ReadHouseNumber();
                streetNumber = addressReader.ReadStreetNumber();

                addressService.ConstructAddress(countryName, cityName, streetName, streetNumber,houseNumber, apartamentBuildingNumber, apartamentNumber);
            }
            else
            {
                countryName = addressReader.ReadCountryName();
                cityName = addressReader.ReadCityName();
                streetName = addressReader.ReadStreetName();
                streetNumber = addressReader.ReadStreetNumber();
                apartamentBuildingNumber = addressReader.ReadApartamentBuildingNumber();
                apartamentNumber = addressReader.ReadApartamentNumber();

                addressService.ConstructAddress(countryName, cityName, streetName, streetNumber, houseNumber, apartamentBuildingNumber, apartamentNumber);
            }

            Address address = addressService.GetAddress();

            return address;

        }
    }
}
