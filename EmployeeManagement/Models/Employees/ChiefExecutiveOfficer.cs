namespace EmployeeManagement.Models.Employees
{
    // don't use. Managers can have managers beneath them
    public class ChiefExecutiveOfficer : IEmployee
    {
        private Address address;
        private Name name;

        // no manager field, because CEO does not have a manager

        private List<IEmployee> employeeList = new List<IEmployee>();

        public ChiefExecutiveOfficer(Name name, Address address)
        {
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
        public void ShowEmployeeDetails()
        {
            foreach (var employee in employeeList)
            {
                employee.ShowEmployeeDetails();
            }
        }
    }
}
