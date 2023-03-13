namespace EmployeeManagement.Models.Employees
{
    public class Developer : Employee
    {
        public Employee? Manager;

        public Developer(Guid devId, Name name, Address address) : base (devId, name, address)
        {
        }

        public override string ShowEmployeeDetails()
        {
            return base.ShowEmployeeDetails();
        }
    }
}
