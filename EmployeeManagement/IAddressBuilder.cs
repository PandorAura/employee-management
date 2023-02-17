namespace EmployeeManagement
{
    public interface IAddressBuilder
    {
        public void BuildCountryName(string countryName);
        public void BuildCityName(string cityName);
        public void BuildStreetName(string streetName);
        public void BuildStreetNumber(int streetNumber);
        public void BuildHouseNumber(int houseNumber);
        public void BuildApartamentBuildingNumber(int apartamentBuildingNumber);
        public void BuildApartamentNumber(int apartamentNumber);
        public Address GetAdress();
    }
}
