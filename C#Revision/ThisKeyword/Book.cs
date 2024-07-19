using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    public class Books
    {
        public string[] title = new string[10]; // Internal data storage


        // Indexer declaration
        public string this[int index]
        {
            get
            {
                // Return the value at the specified index
                return title[index];
            }
            set
            {
                // Set the value at the specified index
                title[index] = value;
            }
        }


    }

   
   

}
