namespace EmployeeManagement
{
    public class Developer : IEmployee
    {
        private string name;
        private Guid empId;
        private Adress adress;
        public void ShowEmployeeDetails()
        {
            Console.WriteLine(adress.GetStreetNumber());
        }
    }
}
