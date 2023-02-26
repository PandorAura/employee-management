//using System.Text.Json;

using EmployeeManagement.Models.Employees;
using JsonFlatFileDataStore;

namespace EmployeeManagement
{
    public class DataPersist
    {
//        const string fileName = @"../../../SavedLoan.json";

//        public void SaveData()
//        {
//            if (File.Exists(fileName))
//        {
//            Console.WriteLine("Reading saved file");
//    string jsonFromFile = File.ReadAllText(fileName);
//        testLoan = JsonSerializer.Deserialize<Loan>(jsonFromFile);
//    testLoan.TimeLastLoaded = DateTime.Now;
//            }

//    string json = JsonSerializer.Serialize(testLoan);
//    File.WriteAllText(fileName, json);

//        }

        // Open database (create new if file doesn't exist)

        public void SaveData(IEmployee emp) {
            var store = new DataStore("data.json");

            // Get employee collection
            var collection = store.GetCollection<IEmployee>();

            // Create new employee instance
            var employee = new IEmployee { Id = 1, Name = "John", Age = 46 };

            // Insert new employee
            // Id is updated automatically to correct next value
            await collection.InsertOneAsync(employee);

            // Update employee
            employee.Name = "John Doe";

            await collection.UpdateOneAsync(employee.Id, employee);

            // Use LINQ to query items
            var results = collection.AsQueryable().Where(e => e.Age > 30);

            // Save instance as a single item
            await store.InsertItemAsync("selected_employee", employee);

            // Single items can be of any type
            await store.InsertItemAsync("counter", 1);
            var counter = await store.GetItem<int>("counter");
        }




}
}

