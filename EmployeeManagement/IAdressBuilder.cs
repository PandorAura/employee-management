namespace EmployeeManagement
{
    public interface IAdressBuilder
    {
        public void BuildStreetName(string streetName);
        public void BuildCityName(string cityName);
        public void BuildStreetNumber(int streetNumber);
        public void BuildHouseNumber(int houseNumber);
        public void BuildCountryName(string countryName);
        public Adress GetAdress();
    }
}
