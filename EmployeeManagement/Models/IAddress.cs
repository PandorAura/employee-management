namespace EmployeeManagement.Models
{
    public interface IAddress
    {
        public void SetCountryName(string countryName);
        public void SetCityName(string cityName);
        public void SetStreetName(string streetName);
        public void SetStreetNumber(int streetNumber);
        public void SetHouseNumber(int houseNumber);
        public void SetApartamentBuildingNumber(int apartamentBuildingNumber);
        public void SetApartamentNumber(int apartamentNumber);
    }
}
