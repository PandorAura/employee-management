namespace EmployeeManagement.Models.Employees
{
    public abstract class Employee
    {
        public Name name;
        public Address address;

        public Employee (Name name, Address address)
        {
            this.name = name;
            this.address = address;
        }
        public abstract void ShowEmployeeDetails();
    }
}
