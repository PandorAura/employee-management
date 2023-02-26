using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using EmployeeManagement;

namespace EmployeeManagement.Services
{
    public class CreateNameService
    {
        string firstName, lastName, middleName;

    public Name CreateName()
        {
            Console.WriteLine("Is the person having a middle name? ");
            bool isHavingAMiddleName = bool.Parse(Console.ReadLine());


            NameBuilder nameBuilder = new NameBuilder();
            NameService nameService = new NameService(nameBuilder);

            Console.WriteLine("The name is: ");
            NameReader nameReader = new NameReader();

            if (isHavingAMiddleName)
            {
                lastName = nameReader.ReadLastName();
                middleName = nameReader.ReadMiddleName();
                firstName = nameReader.ReadFirstName();

                nameService.ConstructName(firstName, middleName, lastName);

            }
            else
            {
                lastName = nameReader.ReadLastName();
                firstName = nameReader.ReadFirstName();

                nameService.ConstructName(firstName, middleName, lastName);
            }

            Name name = nameService.GetName();

            return name;

        }

    }
}
