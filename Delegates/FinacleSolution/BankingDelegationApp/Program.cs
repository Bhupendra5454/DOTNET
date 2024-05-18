using BankingDelegationApp;
using Finacle.Banking.AccountMgmt.Receivers;
using Finacle.Banking.AccountMgmt;

using System.Runtime.InteropServices;

AccountListener listener = new AccountListener();
Account acct12 = new Account(78000);
EventArgs e2= new EventArgs();

//listener.AactivateAccount(acct12, e2); //explicitly invoking function
                                       //direct call

//Register Address of the function while creating delegate
BankingHandler masterAgent=new BankingHandler(listener.DeactivateAccount);
Account acct = new Account(78000);
EventArgs e = new EventArgs();

//Unicast Delegate
masterAgent(acct, e);   //Indirect Call:1

BankingHandler agent1 = new BankingHandler(listener.SendEmail);
BankingHandler agent2= new BankingHandler(listener.SendSMS);

Console.WriteLine("After attaching other agent to master.......");

//registration, attaching, Add handler,plug
masterAgent += agent1;
masterAgent+= agent2;

//Multicast Delegate
//cascade :Chain of function invocation

masterAgent(acct, e);//Indirect Call:1

//unRegistration,detaching,Remove handler,unplug
masterAgent -= agent1;


Console.WriteLine("After unchaining existring  agent  from master.......");
masterAgent(acct, e);//Indirect Call :1
BankingHandler agentWhatsApp = new BankingHandler(listener.SendNotificationOnWhatsApp);
masterAgent += agentWhatsApp;
masterAgent += agent1;


Console.WriteLine("*************************************************");

masterAgent(acct, e);//Indirect Call :1


MathEngineProcessor math = new MathEngineProcessor();
ArithmaticOperaiton masterOperation = new ArithmaticOperaiton(math.Add);

ArithmaticOperaiton opSub = new ArithmaticOperaiton(math.Subract);
ArithmaticOperaiton opMultiply = new ArithmaticOperaiton(math.Multiply);
 

masterOperation += opSub;
masterOperation += opMultiply;
masterOperation += math.Divide;

Console.WriteLine("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");


int result = masterOperation(56 ,2); //one delegate Call


Console.ReadLine();


