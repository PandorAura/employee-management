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

            NameBuilder nameBuilder = new NameBuilder();
            NameService nameService = new NameService(nameBuilder);
            Name name;
            //WithMiddleName name = new WithMiddleName();
            //WithoutMiddleName nameWithoutMiddleName = new WithoutMiddleName();

            Console.WriteLine("Is the person having a middle name? ");
            bool isHavingAMiddleName = bool.Parse(Console.ReadLine());
            Console.WriteLine("The name is: ");
            NameReader nameReader = new NameReader();

            if (isHavingAMiddleName)
            {
                firstName = nameReader.ReadFirstName();
                middleName = nameReader.ReadMiddleName();
                lastName = nameReader.ReadLastName();

                name = nameBuilder.ConstructNameWithMiddleName(firstName, middleName, lastName);
            }
            else
            {
                lastName = nameReader.ReadLastName();
                firstName = nameReader.ReadFirstName();

                name = nameBuilder.ConstructNameWithoutMiddleName(firstName, lastName);
            }


            return name;

        }

    }
}
