using EmployeeManagement;
using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Employees;

// ALL OF THIS CODE should be in a class

string countryName, streetName, cityName, firstName, lastName, middleName;
int houseNumber, streetNumber, apartamentBuildingNumber, apartamentNumber;

AddressBuilder addressBuilder= new AddressBuilder();
AddressService addressDirector = new AddressService(addressBuilder);

Console.WriteLine("Is the person living in a house? ");
bool isLivingInAHouse = bool.Parse(Console.ReadLine());

if (isLivingInAHouse)
{
    Console.WriteLine("The address for x is: ");
    AddressReader addressReader = new AddressReader();

    countryName = addressReader.ReadCountryName();
    cityName = addressReader.ReadCityName();
    streetName = addressReader.ReadStreetName();
    houseNumber = addressReader.ReadHouseNumber();
    streetNumber = addressReader.ReadStreetNumber();

    addressDirector.ConstructAddress(countryName, cityName, streetName, houseNumber, streetNumber);
} 
else
{
    Console.WriteLine("The address for x is: ");
    AddressReader addressReader = new AddressReader();

    countryName = addressReader.ReadCountryName();
    cityName = addressReader.ReadCityName();
    streetName = addressReader.ReadStreetName();
    streetNumber = addressReader.ReadStreetNumber();
    apartamentBuildingNumber = addressReader.ReadApartamentBuildingNumber();
    apartamentNumber = addressReader.ReadApartamentNumber();

    addressDirector.ConstructApartamentAdress(countryName, cityName, streetName, streetNumber, apartamentBuildingNumber, apartamentNumber);
}



Address address = addressDirector.GetAdress();


Console.WriteLine("Is the person having a middle name? ");
bool isHavingAMiddleNamwe = bool.Parse(Console.ReadLine());


NameBuilder nameBuilder = new NameBuilder();
NameService nameDirector = new NameService(nameBuilder);

Console.WriteLine("The name is: ");
NameReader nameReader = new NameReader();

if (isHavingAMiddleNamwe)
{
    lastName = nameReader.ReadLastName();
    middleName = nameReader.ReadMiddleName();
    firstName = nameReader.ReadFirstName();

    nameDirector.ConstructNameWithMiddleName(firstName, lastName, middleName);

}
else
{
    lastName = nameReader.ReadLastName();
    firstName = nameReader.ReadFirstName();

    nameDirector.ConstructNameWithoutMiddleName(firstName, lastName);
} 

Name name = nameDirector.GetName();

Developer developer = new Developer(name, address);

Console.WriteLine("Is the person living in a house? ");
bool isLivingInAHouse2 = bool.Parse(Console.ReadLine());

if (isLivingInAHouse2)
{
    Console.WriteLine("The address for x is: ");
    AddressReader addressReader = new AddressReader();

    countryName = addressReader.ReadCountryName();
    cityName = addressReader.ReadCityName();
    streetName = addressReader.ReadStreetName();
    houseNumber = addressReader.ReadHouseNumber();
    streetNumber = addressReader.ReadStreetNumber();

    addressDirector.ConstructAddress(countryName, cityName, streetName, houseNumber, streetNumber);
}
else
{
    Console.WriteLine("The address for x is: ");
    AddressReader addressReader = new AddressReader();

    countryName = addressReader.ReadCountryName();
    cityName = addressReader.ReadCityName();
    streetName = addressReader.ReadStreetName();
    streetNumber = addressReader.ReadStreetNumber();
    apartamentBuildingNumber = addressReader.ReadApartamentBuildingNumber();
    apartamentNumber = addressReader.ReadApartamentNumber();

    addressDirector.ConstructApartamentAdress(countryName, cityName, streetName, streetNumber, apartamentBuildingNumber, apartamentNumber);
}



Address address2 = addressDirector.GetAdress();


Console.WriteLine("Is the person having a middle name? ");
bool isHavingAMiddleNamwe2 = bool.Parse(Console.ReadLine());



Console.WriteLine("The name is: ");
NameReader nameReader3 = new NameReader();

if (isHavingAMiddleNamwe)
{
    lastName = nameReader.ReadLastName();
    middleName = nameReader.ReadMiddleName();
    firstName = nameReader.ReadFirstName();

    nameDirector.ConstructNameWithMiddleName(firstName, lastName, middleName);

}
else
{
    lastName = nameReader.ReadLastName();
    firstName = nameReader.ReadFirstName();

    nameDirector.ConstructNameWithoutMiddleName(firstName, lastName);
}

Name name2 = nameDirector.GetName();

Manager manager = new Manager(name2, address2);

Console.WriteLine("Is the person living in a house? ");
bool isLivingInAHouse3 = bool.Parse(Console.ReadLine());

if (isLivingInAHouse3)
{
    Console.WriteLine("The address for x is: ");
    AddressReader addressReader = new AddressReader();

    countryName = addressReader.ReadCountryName();
    cityName = addressReader.ReadCityName();
    streetName = addressReader.ReadStreetName();
    houseNumber = addressReader.ReadHouseNumber();
    streetNumber = addressReader.ReadStreetNumber();

    addressDirector.ConstructAddress(countryName, cityName, streetName, houseNumber, streetNumber);
}
else
{
    Console.WriteLine("The address for x is: ");
    AddressReader addressReader = new AddressReader();

    countryName = addressReader.ReadCountryName();
    cityName = addressReader.ReadCityName();
    streetName = addressReader.ReadStreetName();
    streetNumber = addressReader.ReadStreetNumber();
    apartamentBuildingNumber = addressReader.ReadApartamentBuildingNumber();
    apartamentNumber = addressReader.ReadApartamentNumber();

    addressDirector.ConstructApartamentAdress(countryName, cityName, streetName, streetNumber, apartamentBuildingNumber, apartamentNumber);
}



Address address3 = addressDirector.GetAdress();


Console.WriteLine("Is the person having a middle name? ");
bool isHavingAMiddleNamwe3 = bool.Parse(Console.ReadLine());



Console.WriteLine("The name is: ");
NameReader nameReader4 = new NameReader();

if (isHavingAMiddleNamwe3)
{
    lastName = nameReader.ReadLastName();
    middleName = nameReader.ReadMiddleName();
    firstName = nameReader.ReadFirstName();

    nameDirector.ConstructNameWithMiddleName(firstName, lastName, middleName);

}
else
{
    lastName = nameReader.ReadLastName();
    firstName = nameReader.ReadFirstName();

    nameDirector.ConstructNameWithoutMiddleName(firstName, lastName);
}

Name name3 = nameDirector.GetName();


ChiefExecutiveOfficer d = new ChiefExecutiveOfficer(name3, address3);
d.AddManager(manager);
d.AddDeveloper(developer);
d.ShowEmployeeDetails();

// 1. Create Employee
//      Step 1 - Create Name
//      Step 2 - Create Address
// 2. Add CEO
//    - nothing
// 3. Manager
//    - Manager EmpId
//    - Developer Ids
// 4. Add Developer
//    - Manager EmpId