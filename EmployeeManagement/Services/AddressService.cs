using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using EmployeeManagement.Repositorys;
using EmployeeManagement.Services.Validators;

namespace EmployeeManagement.Services
{
    public class AddressService
    {
        AddressBuilder addressBuilder = new AddressBuilder();
        AddressValidator addressValidator = new AddressValidator();
        AddressRepository addressRepository= new AddressRepository();

       public Address ConstructHouseAddress(string countryName, string cityName, string streetName, int houseNumber)
        {
            Address address = addressBuilder.ConstructHouseAddress(countryName, cityName, streetName, houseNumber);
            if (addressValidator.IsAddressValid(address))
            {
                addressRepository.SaveAddress(address);
                return address;
            } 
            else
            {
                throw new Exception("The address provided is not valid. ");
            }
        }

        public Address ConstructApartamentAddress(string countryName, string cityName, string streetName, int apartamentBuildingNumber, int apartamentNumber)
        {
            Address address = addressBuilder.ConstructApartamentAddress(countryName, cityName, streetName, apartamentBuildingNumber, apartamentNumber);
            if (addressValidator.IsAddressValid(address))
            {
                addressRepository.SaveAddress(address);
                return address;
            }
            else
            {
                throw new Exception("The address provided is not valid. ");
            }
        }
    }
}
