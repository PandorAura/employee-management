namespace EmployeeManagement
{
    public class AddressGiver
    {
        private AdressBuilder adressBuilder;

        public AddressGiver( AdressBuilder adressBuilder) 
        { 
            this.adressBuilder = adressBuilder;
        }

        public Adress GetAdress()
        {
            return adressBuilder.GetAdress();  
        }

        public void ConstructAdress (string countryName, string cityName, string streetName,int houseNumber, int streetNumber)
        {
            adressBuilder.BuildHouseNumber(houseNumber);
            adressBuilder.BuildCityName(cityName);
            adressBuilder.BuildStreetName(streetName);
            adressBuilder.BuildCountryName(countryName);
            adressBuilder.BuildStreetNumber(streetNumber);
        }
    }
}
