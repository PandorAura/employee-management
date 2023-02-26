using EmployeeManagement.Models;

namespace EmployeeManagement.Builders
{
    public class NameBuilder : INameBuilder
    {
        private Name name;

        public NameBuilder()
        {
            name = new Name();
        }
        public void WithFirstName(string firstName)
        {
            name.firstName= firstName;
        }

        public void WithMiddleName(string middleName)
        {
            name.middleName = middleName;
        }

        public void WithLastName(string lastName)
        {
            name.lastName = lastName;
        }

        public Name GetName()
        {
            return name;
        }
    }
}
