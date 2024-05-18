using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsApp
{
    public class Maths
    {
       
        public int Add(int num1, int num2) 
        {
            int result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }

        public int Sub(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
            return result;
        }

        public int Multi(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
            return result;
        }

        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
            return result;
        }
    }
}
