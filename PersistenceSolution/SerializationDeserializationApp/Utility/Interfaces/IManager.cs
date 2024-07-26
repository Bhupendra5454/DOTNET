using HR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Utility.Interfaces
{
    public  interface IManager
    {
        bool SerializeData(string fileName);
        List<Person> DeSerializeData(string fileName);



    }
}
