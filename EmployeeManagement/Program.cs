using EmployeeManagement;

AdressBuilder adressBuilder= new AdressBuilder();
AddressGiver addressGiver = new AddressGiver(adressBuilder);
string countryName, streetName, cityName;
int houseNumber, streetNumber;
Console.WriteLine("The address for x is: ");
AdressReader adressReader = new AdressReader();

countryName = adressReader.ReadCountryName();
cityName = adressReader.ReadCityName();
streetName = adressReader.ReadStreetName();
houseNumber = adressReader.ReadHouseNumber();
streetNumber = adressReader.ReadStreetNumber();

addressGiver.ConstructAdress(countryName, cityName, streetName, houseNumber, streetNumber);

Adress adress = addressGiver.GetAdress();


Console.WriteLine(adress.GetStreetNumber());