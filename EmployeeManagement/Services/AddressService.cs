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

        public void ConstructAddress(string countryName, string cityName, string streetName, int streetNumber, int? houseNumber, int? apartamentBuildingNumber, int? apartamentNumber)
        {
           
            if (houseNumber != null)
            {
              

            } else
            {

            }

            if(!ValidateAddress.IsAddressValid(GetAddress()))
            {
                throw new Exception();
            }
        }
    }
}
