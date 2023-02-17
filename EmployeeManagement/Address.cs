using System.ComponentModel;

namespace EmployeeManagement
{
    public class Address : IAddress
    {
        private int streetNumber, houseNumber, apartamentBuildingNumber, apartamentNumber;
        private string streetName, cityName, countryName;

        public string GetCountryName()
        {
            return countryName;
        }
        public string GetCityName()
        {
            return cityName;
        }
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

        public int GetApartamentBuildingNumber()
        {
            return apartamentBuildingNumber;
        }

        public int GetApartamentNumber()
        {
            return apartamentNumber;
        }

        public void SetCountryName(string countryName)
        {
            this.countryName = countryName;
        }
        public void SetCityName(string cityName)
        {
            this.cityName = cityName;
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

        public void SetApartamentBuildingNumber(int apartamentBuildingNumber)
        {
            this.apartamentBuildingNumber = apartamentBuildingNumber;
        }

        public void SetApartamentNumber(int apartamentNumber)
        {
            this.apartamentNumber = apartamentNumber;
        }
    }
}
