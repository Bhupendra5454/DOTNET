using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        // Constructor chaining using 'this'
        public Person() : this("Unknown", 10)
        {
            this.Name = "Bhupendra";
            
            Console.WriteLine("Inside Default Constructor");
        }

        public Person(string name) : this(name, 0)
        {
            Console.WriteLine("Inside Single Parameter Constructor");
        }

        public Person(string name, int age)
        {
            Console.WriteLine("Inside Two Parameter Constructor");
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
