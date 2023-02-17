namespace EmployeeManagement
{
    public class AddressBuilder : IAddressBuilder
    {
        private Address adress;

        public AddressBuilder() 
        {
            this.adress = new Address();
        }

          public void BuildCountryName(string countryName)
        {
            adress.SetCountryName(countryName);
        }


        public void BuildCityName(string cityName)
        {
            adress.SetCityName(cityName);
        }

        public void BuildStreetName(string streetName)
        {
            adress.SetStreetName(streetName);
        }

        public void BuildStreetNumber(int streetNumber)
        {
            adress.SetStreetNumber(streetNumber);
        }
        public void BuildHouseNumber(int houseNumber)
        {
            adress.SetHouseNumber(houseNumber);
        }

        public void BuildApartamentBuildingNumber(int apartamentBuildingNumber)
        {
            adress.SetApartamentBuildingNumber(apartamentBuildingNumber);
        }

        public void BuildApartamentNumber(int apartamentNumber)
        {
            adress.SetApartamentNumber(apartamentNumber);
        }
        public Address GetAdress()
        {
            return this.adress;
        }
    }
}
