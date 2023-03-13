using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using EmployeeManagement.Repositorys;
using EmployeeManagement.Services.Validators;

namespace EmployeeManagement.Services
{
    public class NameService
    {
        NameBuilder nameBuilder = new NameBuilder();
        NameValidator nameValidator = new NameValidator();
        NameRepository nameRepository = new NameRepository();

        public Name ConstructNameWithMiddleName(string firstName, string middleName, string lastName)
        {
           Name name =  nameBuilder.ConstructNameWithMiddleName(firstName, middleName, lastName);
            if (nameValidator.IsNameValid(name)) {
                nameRepository.SaveName(name);
                return name;
            } else
            {
                throw new Exception("The name provided is not valid. ");
            }
        }

        public Name ConstructName(string firstName, string lastName)
        {
            Name name = nameBuilder.ConstructName(firstName, lastName);

            if (nameValidator.IsNameValid(name))
            {
                nameRepository.SaveName(name);
                return name;
            }
            else
            {
                throw new Exception("The name provided is not valid. ");
            }
        }

    }
}
