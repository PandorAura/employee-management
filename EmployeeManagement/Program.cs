using EmployeeManagement;
using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Employees;


Guid devId = new();
EmployeeBuilder employee = new EmployeeBuilder();

Name devName = employee.WithName();
Address devAddress= employee.WithAddress();
Developer developer = new(devId, devName, devAddress);
//data.SaveData(developer);

Guid managerId = new();
Name managerName = employee.WithName();
Address managerAddress = employee.WithAddress();
Manager manager = new(managerId, managerName, managerAddress);
//data.SaveData(manager);

manager.Subordinates.Add(developer);
Console.WriteLine(manager.ShowEmployeeDetails());