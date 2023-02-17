﻿namespace EmployeeManagement
{
    public class NameReader
    {
        public string ReadFirstName()
        {
            string firstName = "";

            while (!IsInputValid(firstName))
            {
                Console.WriteLine("firstName = ");
                firstName= Console.ReadLine();

                if (!IsInputValid(firstName))
                {
                    Console.WriteLine("The value cannot be null. ");
                }
            }
            return firstName;
        }

        public string ReadLastName()
        {
            string lastName = "";

            while (!IsInputValid(lastName))
            {
                Console.WriteLine("lastName = ");
                lastName = Console.ReadLine();

                if (!IsInputValid(lastName))
                {
                    Console.WriteLine("The value cannot be null. ");
                }
            }
            return lastName;
        }

        private bool IsInputValid(string input)
        {
            if (input != "")
                return true;
            return false;
        }
    }
}