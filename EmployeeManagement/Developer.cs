namespace EmployeeManagement
{
    public class Developer : IEmployee
    {
        private Name name;
        //private Guid empId;
        private Address adress;

        public Developer(Name name, Address adress)
        {
            this.name = name;
            this.adress = adress;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine(adress.GetStreetNumber());
        }
    }
}
