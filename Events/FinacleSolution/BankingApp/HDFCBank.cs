using Finacle.Banking.AccountMgmt;
using Finacle.Banking.AccountMgmt.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finacle.Banks
{
    public  class HDFCBank
    {
        public HDFCBank() { 
        }

        public void PerformBankingOperation(Account acct, AccountListener listener)
        {
            //event registration
            acct.deactivate += listener.DeactivateAccount;
            Console.WriteLine(acct.Balance);
            //Method invocation is done
            acct.Withdraw(65000);
            Console.WriteLine(acct.Balance);
        }

    }
}
