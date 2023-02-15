namespace EmployeeManagement
{
    public class Adress : IAdress
    {
        private int streetNumber, houseNumber;
        private string streetName, cityName, countryName;

        public string GetStreetName()
        { 
            return streetName; 
        }
        public int GetStreetNumber()
        {
            return streetNumber;
        }

        public int GetHouseNumber ()
        {
            return houseNumber;
        }

        public string GetCityName()
        {
            return cityName;
        }

        public string GetCountryName()
        {
            return countryName;
        }

        public void SetStreetName(string streetName)
        {
            this.streetName = streetName;
        }

        public void SetStreetNumber(int streetNumber)
        {
           this.streetNumber = streetNumber;
        }

        public void SetHouseNumber(int houseNumber)
        {
            this.houseNumber = houseNumber;
        }

        public void SetCityName(string cityName)
        {
           this.cityName= cityName;
        }

        public void SetCountryName(string countryName)
        {
            this.countryName= countryName;
        }
    }
}
