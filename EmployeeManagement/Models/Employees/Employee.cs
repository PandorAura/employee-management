namespace EmployeeManagement.Models.Employees
{
    public abstract class Employee
    {
        public string EmployeeId;
        public Name Name { get; set; }
        public Address Address { get; set; }

        public Employee (Name name, Address address)
        {
            this.name = name;
            this.address = address;
        }
        public abstract void ShowEmployeeDetails();
    }
}
