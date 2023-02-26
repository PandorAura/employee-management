using EmployeeManagement.Models;

namespace EmployeeManagement.Builders
{
    public interface INameBuilder
    {
        public void WithFirstName(string firstName);
        public void WithMiddleName(string middleName);
        public void WithLastName(string lastName);
        public Name GetName();
    }
}
