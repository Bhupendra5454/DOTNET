using HR.Entities;
using HR.Utility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Utility.Implementations
{
    public class CSVManager : IManager
    {

        public bool SerializeData(string fileName)
        {
            bool status = false;

            // Example data to write
            string[] lines = { "John,Doe,25", "Jane,Smith,30", "Bob,Johnson,40" };
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }


            status = true;
            return status;
        }
        public List<Person> DeSerializeData(string fileName)
        {
            List<Person> people = new List<Person>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line by comma to get individual values
                    string[] parts = line.Split(',');

                    string firstName = parts[0];
                    string lastName = parts[1];
                    int age = int.Parse(parts[2]);
                    Person prn = new Person { Name = firstName, Age = age };
                    people.Add(prn);
                }
            }
            return people;
        }
    }
}
