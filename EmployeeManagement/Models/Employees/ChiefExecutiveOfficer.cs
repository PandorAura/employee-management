namespace EmployeeManagement.Models.Employees
{
    public class ChiefExecutiveOfficer : Employee
    {
        private Guid ceoID;
        private Address address;
        private Name name;
        private List<Employee> employeeList = new List<Employee>();

        public ChiefExecutiveOfficer(Guid ceoID,Name name, Address address) : base (name, address)
        {
            this.ceoID = ceoID;
            this.name = name;
            this.address = address;
        }

        public void AddManager(Manager manager)
        {
            employeeList.Add(manager);
        }

        public void RemoveManager(Manager manager)
        {
            employeeList.Remove(manager);
        }

        public void AddDeveloper(Developer developer)
        {
            employeeList.Add(developer);
        }

        public void RemoveDeveloper(Developer developer)
        {
            employeeList.Remove(developer);
        }

        public override void ShowEmployeeDetails()
        {
            Console.WriteLine($"CEO: {name.lastName}");
            Console.WriteLine("Employees");
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee.name.lastName);
            }
        }
    }
}
