using EmployeeManagement.Models;

namespace EmployeeManagement.Repositorys
{
    public class AddressRepository
    {
        public void SaveAddress(Address address)
        {
            Console.WriteLine($"SAVED ADDRESS {address.DisplayAddress()}");
        }
    }
}
