
namespace BankingApp
{
    public  class Account
    {
        public Double Balance { get; set; }
        public event EventHandler<EventArgs> deactivate;

        public Account(Double Amount)
        {
            Balance = Amount;
        }

        public void Withdraw(Double Amount)
        {
            Double remainmingBalance = Balance - Amount;
            if(remainmingBalance <= 10000)
            {
                EventArgs eventArgs = new EventArgs();
                deactivate(this, eventArgs);
            }
            this.Balance = remainmingBalance;
        }

        public void Deposit(Double Amount) 
        {
            this.Balance = Balance + Amount;   
        }

    }

    
}
