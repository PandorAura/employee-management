using EmployeeManagement.Models;

namespace EmployeeManagement.Services.Validators
{
    public class ValidateAddress
    {
        public static bool IsAddressValid(Address address)
        {
            if (address == null)
            {
                return false;
            }

            if (address.countryName == "" || address.cityName == "" || address.streetName == "" || address.streetNumber == null)
            {
                return false;
            }
            else
            {
                if (address.houseNumber == null && (address.apartamentBuildingNumber == null || address.apartamentNumber == null))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
