using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using System.Net;

namespace EmployeeManagement.Menu
{

    public class AddressMenu
    {
        string countryName, streetName, cityName;
        int houseNumber, apartamentBuildingNumber, apartamentNumber;

        public Address CreateAddress()
        {
            AddressBuilder addressBuilder = new AddressBuilder();
            AddressReader addressReader = new AddressReader();

            Console.WriteLine("Choose between the following options: ");
            Console.WriteLine("1 - the person is living in a house");
            Console.WriteLine("2 - the person is living in an apartment");
            var opt = Console.ReadLine();

            Console.WriteLine("The address is: ");

            switch (opt)
            {
                case "1":
                    countryName = addressReader.ReadCountryName();
                    cityName = addressReader.ReadCityName();
                    streetName = addressReader.ReadStreetName();
                    houseNumber = addressReader.ReadHouseNumber();

                    return addressBuilder.ConstructHouseAddress(countryName, cityName, streetName, houseNumber);

                case "2":
                    countryName = addressReader.ReadCountryName();
                    cityName = addressReader.ReadCityName();
                    streetName = addressReader.ReadStreetName();
                    apartamentBuildingNumber = addressReader.ReadApartamentBuildingNumber();
                    apartamentNumber = addressReader.ReadApartamentNumber();

                    return addressBuilder.ConstructApartamentAddress(countryName, cityName, streetName, apartamentBuildingNumber, apartamentNumber);

                default:
                    throw new Exception("The option chosen doesn't exist!");
            }
        }

    }
}

