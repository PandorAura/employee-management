namespace EmployeeManagement.Models.Employees
{
    public class Manager : Employee //are o lista de angajati
    {
        private Guid managerId;
        private Name name;
        private Address address;

        public Employee manager;
        private List<Employee> Subordinates = new List<Employee>();

        public Manager(Guid managerId, Name name, Address address) : base (name, address)
        {
            this.managerId = managerId;
            this.name = name;
            this.address = address;
        }

        public void AddManager(Manager manager)
        {
            Subordinates.Add(manager);
        }

        public void RemoveManager(Manager manager)
        {
            Subordinates.Remove(manager);
        }

        public void AddDeveloper(Developer developer)
        {
            Subordinates.Add(developer);
        }

        public void RemoveDeveloper(Developer developer)
        {
            Subordinates.Remove(developer);
        }

        public override void ShowEmployeeDetails()
        {
            foreach (var employee in Subordinates)
            {
                Console.WriteLine(employee.name.lastName);
            }
        }
    }
}
