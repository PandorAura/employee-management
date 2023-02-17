using EmployeeManagement;

string countryName, streetName, cityName, firstName, lastName;
int houseNumber, streetNumber;

AddressBuilder addressBuilder= new AddressBuilder();
AddressGiver addressGiver = new AddressGiver(addressBuilder);

Console.WriteLine("The address for x is: ");
AddressReader addressReader = new AddressReader();

countryName = addressReader.ReadCountryName();
cityName = addressReader.ReadCityName();
streetName = addressReader.ReadStreetName();
houseNumber = addressReader.ReadHouseNumber();
streetNumber = addressReader.ReadStreetNumber();

addressGiver.ConstructHouseAddress(countryName, cityName, streetName, houseNumber, streetNumber);

Address adress = addressGiver.GetAdress();



NameBuilder nameBuilder = new NameBuilder();
Civil civil = new Civil(nameBuilder);

Console.WriteLine("The name is: ");
NameReader nameReader = new NameReader();

lastName= nameReader.ReadLastName();
firstName= nameReader.ReadFirstName();


civil.Construct(firstName, lastName);
Name name = civil.GetName();

Developer developer = new Developer(name, adress);
developer.ShowEmployeeDetails();

