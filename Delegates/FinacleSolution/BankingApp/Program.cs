
using Finacle.Banking.AccountMgmt;
using Finacle.Banking.AccountMgmt.Receivers;
using Finacle.Banks;

Console.WriteLine("Welcome to Finacle!");

Account acct = new Account(70000);  //account register
AccountListener listener = new AccountListener();

/*HDFCBank hDFCBank = new HDFCBank();
hDFCBank.PerformBankingOperation(acct, listener);
*/

ICICIBank iCICIBank =new ICICIBank();
iCICIBank.PerformBankingOperation(acct, listener);

Console.ReadLine();
