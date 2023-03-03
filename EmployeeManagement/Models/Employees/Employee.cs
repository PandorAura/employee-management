namespace EmployeeManagement.Models.Employees
{
    public abstract class Employee
    {
        public Guid EmployeeId { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }

        public Employee (Guid id, Name name, Address address)
        {
            EmployeeId = id;
            Name = name;
            Address = address;
        }

        public virtual string ShowEmployeeDetails()
        {
            return $"Employee: {EmployeeId} {Name.DisplayName()} {Address.DisplayAddress()} \n";
        }
    }
}
