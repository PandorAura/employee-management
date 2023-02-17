namespace EmployeeManagement
{
    public class DepartamentEmployees : IEmployee
    {
        private List<IEmployee> emplyeeList = new List<IEmployee>();
        public void ShowEmployeeDetails()
        {
            foreach (var employee in emplyeeList)
            {
                employee.ShowEmployeeDetails();
            }
        }
    }
}
