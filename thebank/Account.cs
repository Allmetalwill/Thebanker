
using System;
using System.Collections.Generic;
using System.Linq;
using thebank;

namespace Bank 
{

   public class Account
    {
     public string name;
     public int number;
     public double balance;

     public Account(string aName, int aNumber, double aBalance)
     {
         name = aName;
         number = aNumber;
         balance = aBalance;
     }
    }

    
}