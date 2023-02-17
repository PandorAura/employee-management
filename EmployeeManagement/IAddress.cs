namespace EmployeeManagement
{
    public interface IAddress
    {
        public void SetCountryName(String countryName);
        public void SetCityName(String cityName);
        public void SetStreetName(String streetName);
        public void SetStreetNumber (int streetNumber);
        public void SetHouseNumber(int houseNumber);
        public void SetApartamentBuildingNumber(int apartamentBuildingNumber);
        public void SetApartamentNumber(int apartamentNumber);
    }
}
