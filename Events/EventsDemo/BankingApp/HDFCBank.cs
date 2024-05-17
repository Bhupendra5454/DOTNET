using BankingApp.Listner;

namespace BankingApp.Bank;

public class HDFCBank
{
    public HDFCBank() { }

    public void PerformBankingOperation(Account account,AccountListners listner)
    {
        account.deactivate += listner.DeactivateAccount;
        Console.WriteLine(account.Balance);
        account.Withdraw(91000);
        Console.WriteLine(account.Balance);
    }
}
