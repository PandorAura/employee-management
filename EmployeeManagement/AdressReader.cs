namespace EmployeeManagement
{
    public class AdressReader
    {
        public String ReadCountryName()
        {
            string countryName = "";

            while (!IsInputValide(countryName))
            {
                Console.WriteLine("countryName = ");
                countryName = Console.ReadLine();

                if (!IsInputValide(countryName))
                {
                    Console.WriteLine("The value cannot be null.");
                }
            }
            return countryName;
         
        }

        public string ReadCityName()
        {
            string cityName = "";

            while (!IsInputValide(cityName))
            {
                Console.WriteLine("cityName = ");
                cityName = Console.ReadLine();

                if (!IsInputValide(cityName))
                {
                    Console.WriteLine("The value cannot be null.");
                }
            }
            return cityName;
        }

        public string ReadStreetName()
        {
            string streetName = "";

            while (!IsInputValide(streetName))
            {
                Console.WriteLine("streetName = ");
                streetName = Console.ReadLine();

                if (!IsInputValide(streetName))
                {
                    Console.WriteLine("The value cannot be null.");
                }
            }
            return streetName;
        }

        public int ReadHouseNumber()
        {
            int? houseNumber = null;

            while (!IsNumberInputValid(houseNumber))
            {
                Console.WriteLine("houseNumber = ");
                var numberRead = Console.ReadLine();
                if (!IsInputValide(numberRead))
                {
                    houseNumber = null;
                    Console.WriteLine("The value cannot be null.");
                }
                else
                {
                    houseNumber = Convert.ToInt32(numberRead);
                }

            }
            return (int)houseNumber;
        }

        public int ReadStreetNumber()
        {
            int? streetNumber = null;

            while (!IsNumberInputValid(streetNumber))
            {
                Console.WriteLine("streetNumber = ");
                var numberRead = Console.ReadLine();
                if (!IsInputValide(numberRead))
                {
                    streetNumber = null;
                    Console.WriteLine("The value cannot be null.");
                }
                else
                {
                    streetNumber = Convert.ToInt32(numberRead);
                }
            }
            return (int)streetNumber;
        }

        private bool IsNumberInputValid(int? numberInput)
        {
            if (numberInput != null)
                return true;
            return false;
        }

        private bool IsInputValide(string input)
        {
            if (input != "")
               return true;
            return false;
        }
    }
}
