using BankingApp;
using BankingApp.Bank;
using BankingApp.Listner;

Account account1 = new Account(100000);
/*Console.WriteLine(Account1.Balance);
Account1.Withdraw(50000);
Console.WriteLine(Account1.Balance);
Account1.Withdraw(60000);
Console.WriteLine(Account1.Balance);
*/
AccountListners listner = new AccountListners();

HDFCBank hDFCBank = new HDFCBank();
hDFCBank.PerformBankingOperation(account1, listner);