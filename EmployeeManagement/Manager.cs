namespace EmployeeManagement
{
    public class Manager : IEmployee
    {
        private Name name;
       // private Guid empId;
        private Address adress;

        public Manager(string Name, Address adress)
        {
            this.name = name;
            this.adress = adress;
        }       

        public void ShowEmployeeDetails()
        {
            System.Console.WriteLine(name.GetLastName());
        }
    }
}
