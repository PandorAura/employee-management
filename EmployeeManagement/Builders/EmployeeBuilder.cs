using EmployeeManagement.Menu;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Employees;

namespace EmployeeManagement.Builders
{
    public class EmployeeBuilder
    {
        NameMenu nameMenu = new NameMenu();
        AddressMenu addressMenu = new AddressMenu();
        public Name WithName()
        {
            return nameMenu.CreateName();
        }

        public Address WithAddress()
        {
            return addressMenu.CreateAddress();
        }
    }
}
