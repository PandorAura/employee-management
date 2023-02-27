using EmployeeManagement;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Employees;
using EmployeeManagement.Services;

DataPersist data = new DataPersist();

Guid devId = new Guid();
CreateNameService createNameService= new CreateNameService();
Name devName = createNameService.CreateName();
CreateAddressService createAddressService= new CreateAddressService();
Address devAddress= createAddressService.CreateAddress();
Developer developer = new Developer(devId, devName, devAddress);
//data.SaveData(developer);

Guid managerId = new Guid();
Name managerName = createNameService.CreateName();
Address managerAddress = createAddressService.CreateAddress();
Manager manager = new Manager(managerId, managerName, managerAddress);
//data.SaveData(manager);

Guid ceoID = new Guid();
Name ceoName = createNameService.CreateName();
Address ceoAddress = createAddressService.CreateAddress();
ChiefExecutiveOfficer ceo = new ChiefExecutiveOfficer(ceoID,ceoName, ceoAddress);
//data.SaveData(ceo);


ceo.AddManager(manager);
ceo.AddDeveloper(developer);
ceo.ShowEmployeeDetails();
