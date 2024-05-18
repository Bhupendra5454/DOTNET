using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDelegationApp
{
    //What do you declare in namespace
    //namespace always consist of types
    //reference types:
    //class, interface, delegate, event

    //class, interface, child namespace
    //Delcaring Function Pointer
    public delegate void BankingHandler(object? o, EventArgs eventArgs);
    public delegate int ArithmaticOperaiton(int num1, int num2);

}
