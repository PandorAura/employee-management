using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using EmployeeManagement.Services;

namespace EmployeeManagement.Menu
{
    public class NameMenu
    {
        string firstName, lastName, middleName;


        public Name CreateName()
        {
            NameService nameService = new NameService();
            NameReader nameReader = new NameReader();

            Console.WriteLine("Choose between the following options: ");
            Console.WriteLine("1 - the person has a middle name");
            Console.WriteLine("2 - the person doesn't have a middle name");
            var opt = Console.ReadLine();

            Console.WriteLine("The name is: ");

            switch (opt)
            {
                case "1":
                    firstName = nameReader.ReadFirstName();
                    middleName = nameReader.ReadMiddleName();
                    lastName = nameReader.ReadLastName();

                    return nameService.ConstructNameWithMiddleName(firstName, middleName, lastName);

                case "2":
                    lastName = nameReader.ReadLastName();
                    firstName = nameReader.ReadFirstName();

                    return nameService.ConstructName(firstName, lastName);

                default:
                    throw new Exception("The option chosen doesn't exist!");
            }
        }

    }
}
