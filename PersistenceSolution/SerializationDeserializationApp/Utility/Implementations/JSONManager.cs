using HR.Entities;
using HR.Utility.Interfaces;
using System.Text.Json;

namespace HR.Utility.Implementations
{
    public class JSONManager : IManager
    {
        public bool SerializeData(string fileName)
        {
            bool status = false;
            List<Person> list = new List<Person>();
            list.Add(new Person { Age = 48, Name = "Ravi" });
            list.Add(new Person { Age = 22, Name = "Pragati" });
            list.Add(new Person { Age = 21, Name = "Ajinkya" });

            var options = new JsonSerializerOptions { IncludeFields = true };
            var peopleJson = JsonSerializer.Serialize(list, options);
            File.WriteAllText(fileName, peopleJson);
            status = true;
            return status;
        }
        public List<Person> DeSerializeData(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            List<Person> jsonPeople = JsonSerializer.Deserialize<List<Person>>(jsonString);
            return jsonPeople;

        }
    }
}
