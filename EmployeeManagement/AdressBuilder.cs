namespace EmployeeManagement
{
    public class AdressBuilder : IAdressBuilder
    {
        private Adress adress;

        public AdressBuilder() 
        {
            this.adress = new Adress();
        }
        public void BuildCityName(string cityName)
        {
            adress.SetCityName(cityName);
        }
        public void BuildCountryName(string countryName)
        {
            adress.SetCountryName(countryName);
        }

        public void BuildHouseNumber(int houseNumber)
        {
            adress.SetHouseNumber(houseNumber);
        }

        public void BuildStreetName(string streetName)
        {
            adress.SetStreetName(streetName);
        }

        public void BuildStreetNumber(int streetNumber)
        {
            adress.SetStreetNumber(streetNumber);
        }

        public Adress GetAdress()
        {
            return this.adress;
        }
    }
}
