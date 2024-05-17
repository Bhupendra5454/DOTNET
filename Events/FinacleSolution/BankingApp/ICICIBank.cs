using Finacle.Banking.AccountMgmt;
using Finacle.Banking.AccountMgmt.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finacle.Banks
{
    public class ICICIBank
    {
        public ICICIBank()
        {

        }

        public void PerformBankingOperation(Account acct,AccountListener listener)
        {
            //event registration
            acct.deactivate += listener.DeactivateAccount;
            acct.deactivate += listener.SendEmail;
            acct.deactivate += listener.SendSMS;

            Console.WriteLine(acct.Balance);
            //Method invocation is done
            acct.Withdraw(65000);
            Console.WriteLine(acct.Balance);
        }
    }
}
