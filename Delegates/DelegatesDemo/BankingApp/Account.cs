
namespace BankingApp
{
    public class Account
    {
        public Double Balance { get; set; }

        public Account(Double amount)
        {
            Balance = amount;
        }

        public void Withdraw(Double amount)
        {
            Double remainingBalance = Balance - amount;
            this.Balance = remainingBalance;
        }

        public void Deposit(Double amount)
        {
            this.Balance = Balance + amount;
        }
    }
}
