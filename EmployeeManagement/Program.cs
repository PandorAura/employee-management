using EmployeeManagement;

string countryName, streetName, cityName, firstName, lastName, middleName;
int houseNumber, streetNumber, apartamentBuildingNumber, apartamentNumber;

AddressBuilder addressBuilder= new AddressBuilder();
AddressGiver addressGiver = new AddressGiver(addressBuilder);

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

    addressGiver.ConstructHouseAddress(countryName, cityName, streetName, houseNumber, streetNumber);
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

    addressGiver.ConstructApartamentAdress(countryName, cityName, streetName, streetNumber, apartamentBuildingNumber, apartamentNumber);
}



Address adress = addressGiver.GetAdress();


Console.WriteLine("Is the person having a middle name? ");
bool isHavingAMiddleNamwe = bool.Parse(Console.ReadLine());


NameBuilder nameBuilder = new NameBuilder();
Civil civil = new Civil(nameBuilder);

Console.WriteLine("The name is: ");
NameReader nameReader = new NameReader();

if (isHavingAMiddleNamwe)
{
    lastName = nameReader.ReadLastName();
    middleName = nameReader.ReadMiddleName();
    firstName = nameReader.ReadFirstName();

    civil.ConstructNameWithMiddleName(firstName, lastName, middleName);

}
else
{
    lastName = nameReader.ReadLastName();
    firstName = nameReader.ReadFirstName();

    civil.ConstructNameWithoutMiddleName(firstName, lastName);
} 

Name name = civil.GetName();

Developer developer = new Developer(name, adress);
developer.ShowEmployeeDetails();

