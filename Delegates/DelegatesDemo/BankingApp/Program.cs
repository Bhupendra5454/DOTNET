using BankingApp;
using BankingApp.Handler;
using BankingApp.Listner;
using MathsApp;
using MathsApp.Handler;

Account account1 = new Account(70000);
EventArgs e = new EventArgs();
AccountListener listener = new AccountListener();
listener.AactivateAccount(account1, e);

BankingHandler masterHandler = new BankingHandler(listener.DeactivateAccount);
masterHandler(account1, e);

BankingHandler handler1 = new BankingHandler(listener.SendEmail);
BankingHandler handler2 = new BankingHandler(listener.SendSMS);

masterHandler += handler1;
masterHandler += handler2;

masterHandler(account1, e);
Console.WriteLine("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
Maths maths1 = new Maths();
MathsHandler masterHandler1 = new MathsHandler(maths1.Add);
masterHandler1(5, 5);

MathsHandler mHandler1 = new MathsHandler(maths1.Sub);
MathsHandler mHandler2 = new MathsHandler(maths1.Multi);
MathsHandler mHandler3 = new MathsHandler(maths1.Divide);
masterHandler1 += mHandler1;
masterHandler1 += mHandler2;
masterHandler1 += mHandler3;

masterHandler1(10, 10);

Console.ReadLine();

