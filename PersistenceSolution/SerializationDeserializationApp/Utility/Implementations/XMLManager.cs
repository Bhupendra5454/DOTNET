
using HR.Entities;
using System.Xml.Serialization;
using HR.Utility.Interfaces;

namespace HR.Utility.Implementations
{
    public class XMLManager : IManager
    {
        public bool SerializeData(string fileName)
        {
            bool status = false;

            List<Person> list = new List<Person>();
            list.Add(new Person { Age = 26, Name = "Seema" });
            list.Add(new Person { Age = 12, Name = "Manoj" });
            list.Add(new Person { Age = 23, Name = "Jai" });

            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                serializer.Serialize(stream, list);
            }
            status = true;


            return status;
        }
        public List<Person> DeSerializeData(string fileName)
        {
            List<Person> people = new List<Person>();
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                people = serializer.Deserialize(stream) as List<Person>;
            }
            return people;
        }

    }
}
