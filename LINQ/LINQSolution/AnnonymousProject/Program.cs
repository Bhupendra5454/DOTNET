using AnnonymousProject;
using Banking;
using Transflower;
using System.Linq;

Account acct = new Account(45000);
acct.Balance = 87000;

Person prn = new ();   //Annonymous Type
prn.FirstName = "Sachin";
prn.LastName = "Sonawane";

//Property Initializer syntax
Person prn2 = new Person { FirstName="Shweta", LastName="Hinge" };


//Annonymous Type
// a type with a class declaration

//Variant Data Type
var emp = new { Id=45, 
                JoinedDate=new DateTime(2024,5,21 ),
                FirstName="Pragati", LastName="Bangar",
                ContactNumber="9883475847"};

Console.WriteLine(emp.FirstName + " "+ emp.LastName);

//strong datatype
double amount = 546.76;

int count = 56;
count = 876;     //string typing
 



//var data type
var number1 = 87;  //at runtime type of variable is decided
number1 = 56;
number1 = 8764;

dynamic result = 765;
result = false;
result = true;
result = new
{
    Id = 45,
    JoinedDate = new DateTime(2024, 5, 21),
    FirstName = "Pragati",
    LastName = "Bangar",
    ContactNumber = "9883475847"
};


SavingAccount sAcct = new SavingAccount(90000);
sAcct.Deposit(780);         //Non-static functions
sAcct.Withdraw(45);         //Member functions
sAcct.ShowMiniStatement();

//These are  Extension Methods

sAcct.PrintStatement();         //these are static methods of BankWroker
sAcct.UpdateCustomerDashboard();

string fullName = "Ravi Tambade";
fullName.ShowCustomizedString();

//Anonymous method
TransflowerOperations registerAgent = delegate (string msg)
{
    Console.WriteLine(msg + " is successfully Registered....");
};

//Annonymous Method
//Inline function
//Arrow Function
//Lambda Expression
TransflowerOperations approvalAgent = (string msg) =>{Console.WriteLine(msg + ", your admission is approved.");};

registerAgent("Rajiv");
approvalAgent("Jeevan");

List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14 };

//to filter numbers which are even numbers
/*List<int> evenNumbers = new List<int>();
foreach (int number in numbers)
{
    int reminder = number % 2;
    if (reminder == 0)
    {
        evenNumbers.Add(number *10);
    }
}
*/
//var evenNumbers=numbers.Where( x=>x%2==0).Select(x=>x*10);

//year 2008
var evenNumbers= from number in numbers where number%2==0 select number*10;

//will print all even numbers
foreach( int number in evenNumbers)
{ 
    Console.WriteLine(number); 
}

List<int> numlist = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
List<int> evennumber = new List<int>();
foreach( int number in numlist)
{
    Console.WriteLine(number);
}

var evennum = from number in numlist where number % 2 == 0 select number;
foreach( int number in evennum)
{ 
   evennumber.Add(number);
}





Console.ReadLine();
