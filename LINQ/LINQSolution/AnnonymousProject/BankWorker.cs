using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{

    //Block inheritance
    public  static   class BankWorker
    {
       
        public static  void PrintStatement(this Account o)
        {
            Console.WriteLine("Printing Bank Account statement....");
            Console.WriteLine("Balance=" + o.Balance);

        }
        public static  void SendSMS(this Account o)
        {
            Console.WriteLine("Bank report is sent to registered mobile number");

        }
        public static void UpdateCustomerDashboard(this Account o)
        {
            Console.WriteLine("Customer Dashobard is updated with latest Bank account status");

        }


        public static void ShowCustomizedString(this string s)
        {
            Console.WriteLine("Customized string is getting shown from BankWorker");
        }

    }
}
