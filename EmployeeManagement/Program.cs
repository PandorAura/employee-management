using EmployeeManagement;
using EmployeeManagement.Menu;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Employees;

DataPersist data = new();

Guid devId = new();
NameMenu createNameService= new();
AddressMenu createAddressService = new();

Name devName = createNameService.CreateName();
Address devAddress= createAddressService.CreateAddress();
Developer developer = new(devId, devName, devAddress);
//data.SaveData(developer);

Guid managerId = new();
Name managerName = createNameService.CreateName();
Address managerAddress = createAddressService.CreateAddress();
Manager manager = new(managerId, managerName, managerAddress);
//data.SaveData(manager);

manager.Subordinates.Add(developer);
Console.WriteLine(manager.ShowEmployeeDetails());