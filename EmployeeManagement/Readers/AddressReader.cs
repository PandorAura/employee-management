namespace EmployeeManagement.Readers
{
    public class AddressReader
    {
        public string ReadCountryName()
        {
            string countryName = "";

            while (!IsInputValid(countryName))
            {
                Console.WriteLine("countryName = ");
                countryName = Console.ReadLine();

                if (!IsInputValid(countryName))
                {
                    Console.WriteLine("The value cannot be null.");
                }
            }
            return countryName;
        }

        public string ReadCityName()
        {
            string cityName = "";

            while (!IsInputValid(cityName))
            {
                Console.WriteLine("cityName = ");
                cityName = Console.ReadLine();

                if (!IsInputValid(cityName))
                {
                    Console.WriteLine("The value cannot be null.");
                }
            }
            return cityName;
        }

        public string ReadStreetName()
        {
            string streetName = "";

            while (!IsInputValid(streetName))
            {
                Console.WriteLine("streetName = ");
                streetName = Console.ReadLine();

                if (!IsInputValid(streetName))
                {
                    Console.WriteLine("The value cannot be null.");
                }
            }
            return streetName;
        }

        public int? ReadHouseNumber()
        {
            int? houseNumber = null;

            while (!IsNumberInputValid(houseNumber))
            {
                Console.WriteLine("houseNumber = ");
                var numberRead = Console.ReadLine();
                if (!IsInputValid(numberRead))
                {
                    houseNumber = null;
                    Console.WriteLine("The value cannot be null.");
                }
                else
                {
                    houseNumber = Convert.ToInt32(numberRead);
                }

            }
            return houseNumber;
        }

        public int? ReadApartamentBuildingNumber()
        {
            int? apartamentBuildingNumber = null;

            while (!IsNumberInputValid(apartamentBuildingNumber))
            {
                Console.WriteLine("apartamentBuildingNumber = ");
                var numberRead = Console.ReadLine();
                if (!IsInputValid(numberRead))
                {
                    apartamentBuildingNumber = null;
                    Console.WriteLine("The value cannot be null.");
                }
                else
                {
                    apartamentBuildingNumber = Convert.ToInt32(numberRead);
                }

            }
            return apartamentBuildingNumber;
        }

        public int? ReadApartamentNumber()
        {
            int? apartamentNumber = null;
            while (!IsNumberInputValid(apartamentNumber))
            {
                Console.WriteLine("apartamentNumber = ");
                var numberRead = Console.ReadLine();
                if (!IsInputValid(numberRead))
                {
                    apartamentNumber = null;
                    Console.WriteLine("The value cannot be null.");
                }
                else
                {
                    apartamentNumber = Convert.ToInt32(numberRead);
                }

            }
            return apartamentNumber;
        }

        public int? ReadStreetNumber()
        {
            int? streetNumber = null;

            while (!IsNumberInputValid(streetNumber))
            {
                Console.WriteLine("streetNumber = ");
                var numberRead = Console.ReadLine();
                if (!IsInputValid(numberRead))
                {
                    streetNumber = null;
                    Console.WriteLine("The value cannot be null.");
                }
                else
                {
                    streetNumber = Convert.ToInt32(numberRead);
                }
            }
            return streetNumber;
        }

        private bool IsNumberInputValid(int? numberInput)
        {
            if (numberInput != null)
                return true;
            return false;
        }

        private bool IsInputValid(string input)
        {
            if (input != "")
                return true;
            return false;
        }
    }
}
