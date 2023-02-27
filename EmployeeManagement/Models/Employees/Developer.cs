namespace EmployeeManagement.Models.Employees
{
    public class Developer : Employee
    {
        private Guid empId;
        private Name name;
        private Address address;
        public Employee Manager;

        public Developer(Guid empId, Name name, Address address) : base (name, address)
        {
            this.empId = empId;
            this.name = name;
            this.address = address;
        }

        public override void ShowEmployeeDetails()
        {
            Console.WriteLine(name.lastName);
        }
    }
}
