using Serialization.Entity;
using Serialization.Manager;

JSONManager jSONManager = new JSONManager();
jSONManager.SetJSONSampleData();
List<Employee> Employees = jSONManager.ReadJSONSampleData();
foreach (Employee employee in Employees)
{
    Console.WriteLine(employee);
}