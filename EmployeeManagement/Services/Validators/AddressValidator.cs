using EmployeeManagement.Models;

namespace EmployeeManagement.Services.Validators
{
    public class AddressValidator
    {
        public bool IsAddressValid(Address address)
        {
            if (address is HouseAddress houseAddress)
            {
               if (houseAddress.HouseNumber == null)
                    return false;
            }

            if (address is ApartamentAddress apartamentAddress)
            {
                if ((apartamentAddress.ApartamentNumber == null) || (apartamentAddress.BuildingNumber == null))
                    return false;
            }
            if (address.CountryName == "" || address.CityName == "" || address.StreetName == "")
            {
                return false;
            }

            return true;
        }
    }
}
