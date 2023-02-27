using EmployeeManagement.Models;

namespace EmployeeManagement.Services.Validators
{
    public class ValidateAddress
    {
        public bool IsAddressValid(Address address)
        {
            if (address == null)
            {
                return false;
            }

            if (address.CountryName == "" || address.CityName == "" || address.StreetName == "" || address.StreetNumber == null)
            {
                return false;
            }
            else
            {
                if (address.HouseNumber == null && (address.ApartamentBuildingNumber == null || address.ApartamentNumber == null))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
