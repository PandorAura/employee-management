using EmployeeManagement.Builders;
using EmployeeManagement.Models;

namespace EmployeeManagement
{
    public class NameService
    {
        private NameBuilder nameBuilder;

        public NameService(NameBuilder nameBuilder)
        {
            this.nameBuilder = nameBuilder;
        }

        public Name GetName()
        {
            return this.nameBuilder.GetName();
        }

        public void ConstructName(string firstName,string? middleName, string lastName)
        {
            this.nameBuilder.WithFirstName(firstName);
            if (middleName!= null)
            {
                this.nameBuilder.WithMiddleName(middleName);
            }
            this.nameBuilder.WithLastName(lastName);
        }
     
    }
}
