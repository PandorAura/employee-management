using EmployeeManagement.Builders;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
   
    public class CreateAddressService
    {
        string countryName, streetName, cityName;
        int houseNumber, streetNumber, apartamentBuildingNumber, apartamentNumber;

        AddressBuilder addressBuilder = new AddressBuilder();
        AddressService addressService = new AddressService(addressBuilder);

        public Address CreateAddress()
        {
            Console.WriteLine("Is the person living in a house? ");
            bool isLivingInAHouse = bool.Parse(Console.ReadLine());

            if (isLivingInAHouse)
            {
                Console.WriteLine("The address for x is: ");
                AddressReader addressReader = new AddressReader();

                countryName = addressReader.ReadCountryName();
                cityName = addressReader.ReadCityName();
                streetName = addressReader.ReadStreetName();
                houseNumber = addressReader.ReadHouseNumber();
                streetNumber = addressReader.ReadStreetNumber();

                addressService.ConstructAddress(countryName, cityName, streetName, houseNumber, streetNumber);
            }
            else
            {
                Console.WriteLine("The address for x is: ");
                AddressReader addressReader = new AddressReader();

                countryName = addressReader.ReadCountryName();
                cityName = addressReader.ReadCityName();
                streetName = addressReader.ReadStreetName();
                streetNumber = addressReader.ReadStreetNumber();
                apartamentBuildingNumber = addressReader.ReadApartamentBuildingNumber();
                apartamentNumber = addressReader.ReadApartamentNumber();

                addressService.ConstructApartamentAdress(countryName, cityName, streetName, streetNumber, apartamentBuildingNumber, apartamentNumber);
            }



            Address address = addressService.GetAdress();

            return address;

        }

       
    }
}
