using EmployeeManagement.Models;

namespace EmployeeManagement.Builders
{
    public class NameBuilder
    {
        public WithoutMiddleName ConstructNameWithoutMiddleName (string firstName, string lastName)
        {
            WithoutMiddleName name = new WithoutMiddleName();
            name.FirstName = firstName;
            name.LastName = lastName;

            return name;
        }

        public WithMiddleName ConstructNameWithMiddleName (string firstName, string middleName, string lastName)
        {
            WithMiddleName name = new WithMiddleName();
            name.FirstName = firstName;
            name.MiddleName = middleName;
            name.LastName = lastName;

            return name;
        }
    }
}
