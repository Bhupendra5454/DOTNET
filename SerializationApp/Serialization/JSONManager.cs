using System;
using System.Text.Json;
using System.Xml.Serialization;
using Serialization.Entity;

namespace Serialization.Manager
{
    public class JSONManager
    {
        public JSONManager() { }

        //Deserialization logic
        public List<Employee> ReadJSONSampleData()
        {
            //Retrive data from sample given to testers
            //DeSerialization of data from people.json
            //Use File IO
            //Use JsonSerializer.Deserialize method
            //retrieve list of person data
            //return list of person data
            string fileName = @"C:\C#\DOTNET\DOTNET\SerializationApp\Employees.json";
            string jsonString = File.ReadAllText(fileName);
            List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            return jsonEmployees;
        }


        //Serialization
        public bool SetJSONSampleData()
        {
            bool status = false;
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Age = 27, Name = "Bhupendra" });
            list.Add(new Employee { Age = 24, Name = "Akshay" });
            list.Add(new Employee { Age = 23, Name = "Ajinkya" });

            string fileName = @"C:\C#\DOTNET\DOTNET\SerializationApp\Employees.json";

            var options = new JsonSerializerOptions { IncludeFields = true };
            var EmployeeJson = JsonSerializer.Serialize<List<Employee>>(list, options);
            File.WriteAllText(fileName, EmployeeJson);
            status = true;
            return status;


        }

    }
}