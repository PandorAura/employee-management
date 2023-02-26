namespace EmployeeManagement.Models.Employees
{
    public class Developer : IEmployee
    {
        private Name name;
        //private Guid empId;
        private Address address;

        // Add field -
        // public IEmployee Manager;

        public Developer(Name name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine(address.streetNumber);
        }
    }
}
