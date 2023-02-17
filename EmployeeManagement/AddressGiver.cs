namespace EmployeeManagement
{
    public class AddressGiver
    {
        private AddressBuilder addressBuilder;

        public AddressGiver( AddressBuilder adressBuilder) 
        { 
            this.addressBuilder = adressBuilder;
        }

        public Address GetAdress()
        {
            return addressBuilder.GetAdress();  
        }

        public void ConstructHouseAddress (string countryName, string cityName, string streetName,int houseNumber, int streetNumber)
        {
            addressBuilder.BuildCountryName(countryName);
            addressBuilder.BuildCityName(cityName);
            addressBuilder.BuildStreetName(streetName);
            addressBuilder.BuildStreetNumber(streetNumber);
            addressBuilder.BuildHouseNumber(houseNumber);

        }

        public void ConstructApartamentAdress(string countryName, string cityName, string streetName, int streetNumber, int apartamentBuildingNumber, int apartamentNumber)
        {
            addressBuilder.BuildCityName(cityName);
            addressBuilder.BuildStreetName(streetName);
            addressBuilder.BuildCountryName(countryName);
            addressBuilder.BuildStreetNumber(streetNumber);
            addressBuilder.BuildApartamentBuildingNumber(apartamentBuildingNumber);
            addressBuilder.BuildApartamentNumber(apartamentNumber);
        }
    }
}
