using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finacle.Banking.AccountMgmt
{
    //Business Class
    public class Account
    {
        public double Balance { get; set; }
        public event EventHandler<EventArgs> deactivate;

        public Account(double amount)
        {
            Balance = amount;
        }
       
        public  void Withdraw(double amount)
        {
            //Banking Business Logic
            double predictedBalance = Balance - amount;

            //Condiction, Rule
            if(predictedBalance <=  10000) 
            {
                //trigger event
                //Fire event
                //raise event "deactivate"
                //Do something
                EventArgs eventArgs = new EventArgs();
                deactivate(this,eventArgs);
            }
            this.Balance = predictedBalance;
        }

        public void Deposit(double amount)
        {
            this.Balance = Balance + amount;
        }
    }
}
