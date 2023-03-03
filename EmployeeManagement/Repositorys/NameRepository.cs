using EmployeeManagement.Models;

namespace EmployeeManagement.Repositorys
{
    public class NameRepository
    {
        public void SaveName(Name name)
        {
            Console.WriteLine($"SAVED NAME {name.DisplayName()}");
        }
    }
}
