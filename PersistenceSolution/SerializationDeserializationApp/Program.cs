 
using HR.Utility.Interfaces;
using HR.Utility.Implementations;
using HR.Entities;

Console.WriteLine("JSON Serialization");
string fileName = @"C:\C#\DOTNET\DOTNET\PersistenceSolution\People.json";
IManager mgr = new JSONManager();
bool status = mgr.SerializeData(fileName);
List<Person> reStoredPeople=mgr.DeSerializeData(fileName);
foreach(Person person in reStoredPeople)
{
    Console.WriteLine(person);
}


Console.WriteLine("CSV Serialization");
string csvFileName = @"C:\C#\DOTNET\DOTNET\PersistenceSolution\People.csv";
IManager cSVManager = new CSVManager();
bool csvStatus = cSVManager.SerializeData(csvFileName);
List<Person> reStoredCsvPeople = cSVManager.DeSerializeData(csvFileName);
foreach (Person person in reStoredCsvPeople)
{
    Console.WriteLine(person);
}


Console.WriteLine("XML Serialization");
IManager xmlManager = new XMLManager();
string xmlFileName = @"C:\C#\DOTNET\DOTNET\PersistenceSolution\People.xml";
bool xmlStatus = xmlManager.SerializeData(xmlFileName);
List<Person> reStoredXmlPeople = xmlManager.DeSerializeData(xmlFileName);
foreach (Person person in reStoredXmlPeople)
{
    Console.WriteLine(person);
}

Console.ReadLine();
