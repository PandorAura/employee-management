namespace EmployeeManagement.Models.Employees
{
    public class Manager : IEmployee //are o lista de angajati
    {
        private Guid empId;
        private Name name;
        private Address adress;

        public IEmployee manager;
        private List<IEmployee> Subordinates = new List<IEmployee>();

        public Manager(Name name, Address address)
        {
            name = name;
            adress = address;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine(name.GetLastName());
        }
    }
}
