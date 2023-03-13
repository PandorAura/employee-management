using EmployeeManagement.Models;

namespace EmployeeManagement.Builders
{
    public class NameBuilder
    {
        public Name ConstructName(string firstName, string lastName)
        {
            Name name = new Name();
            name.FirstName = firstName;
            name.LastName = lastName;

            return name;
        }

        public NameWithMiddleName ConstructNameWithMiddleName (string firstName, string middleName, string lastName)
        {
            NameWithMiddleName name = new NameWithMiddleName();
            name.FirstName = firstName;
            name.MiddleName = middleName;
            name.LastName = lastName;

            return name;
        }
    }
}
