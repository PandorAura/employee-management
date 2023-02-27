//using System.Text.Json;

using EmployeeManagement.Models.Employees;
using JsonFlatFileDataStore;

namespace EmployeeManagement
{
    public class DataPersist
    {
        public async void SaveData(Employee emp) {

            var store = new DataStore("data.json");
            var collection = store.GetCollection<Employee>();
            await collection.InsertOneAsync(emp);
        }
    }
}

