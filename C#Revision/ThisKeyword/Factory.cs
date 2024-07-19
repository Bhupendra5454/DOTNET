using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
  
    public class Factory
    {

        private string cName;
        private string cAdd;
        private int cRegiNo;
        private string contact;

        private Factory()
        {
            this.cName = "Transflover Pvt Ltd";
            this.cAdd = "Satara Road Pune";
            cRegiNo = 411046;
            contact = "9175116616";
        }

        private static Factory refrance = null;

        public void GetDetails()
        {
            Console.WriteLine("Factory Name : " + cName);
            Console.WriteLine("Factory Address : " + cAdd);
            Console.WriteLine("Factory Registration No : " + cRegiNo);
            Console.WriteLine("Factory Contact No : " + contact);
        }

        public static Factory GetInstance()
        {
            if (refrance == null)
                refrance = new Factory();
            return refrance;
        }

        public void setFactoryName(string name)
        {
            this.cName = name;
        }





    }
}
