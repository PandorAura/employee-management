namespace EmployeeManagement
{
    public interface IAdress
    {
        public void SetStreetName(String streetName);
        public void SetStreetNumber (int streetNumber);
        public void SetHouseNumber(int houseNumber);
        public void SetCityName(String cityName);

        public void SetCountryName(String countryName);
    }
}
