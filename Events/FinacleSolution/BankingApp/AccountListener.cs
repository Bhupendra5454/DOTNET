using Finacle.Banking.AccountMgmt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finacle.Banking.AccountMgmt.Receivers
{
        //Response
    public  class AccountListener
    {
        public AccountListener() { }
        public void DeactivateAccount(object? sender,EventArgs e) {
            Console.WriteLine("Your account has been deactivated due to insufficient funds");
        }

        public void AactivateAccount(object? sender, EventArgs e)
        {
            Console.WriteLine("Your account has been activated. Enjoy Banking with us");
        }

        public void SendEmail(object? sender,EventArgs e)
        {
            Console.WriteLine("Email has been sent to your registered Email Id");
        }

        public void SendSMS(object? sender,EventArgs e)
        {
            Console.WriteLine("SMS has been sent to your registered contact Number");

        }
    }

}
