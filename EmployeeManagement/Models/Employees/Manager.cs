namespace EmployeeManagement.Models.Employees
{
    public class Manager : Employee
    {
        public List<Employee> Subordinates { get; set; } = new List<Employee>();

        public Manager(Guid managerId, Name name, Address address) : base(managerId, name, address)
        {
        }

        public override string ShowEmployeeDetails()
        {
            string details = base.ShowEmployeeDetails();
            details += "Subordinates: \n";
            foreach (var employee in Subordinates)
            {
                details += "---" + employee.ShowEmployeeDetails() + "\n";
            }
            return details;
        }
    }
}
