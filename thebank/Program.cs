using System;
using Bank;

namespace thebank
{
    class Program
    {
        static void Main(string[] args)
        {
         
        int num;
    string userChoice;
    
    do 
    {
        Console.WriteLine("Select the number of your choice: ");
        Console.WriteLine("1: Open Account");
        Console.WriteLine("2: List Account");
        Console.WriteLine("3: Show (individual) account details");
        Console.WriteLine("4: Enter Deposit");
        Console.WriteLine("5: Enter withdrawal");
        Console.WriteLine("6: Enter transfar");
        Console.WriteLine("7: Exit Menu");
        Console.Write("Enter the number of your choice: ");
        userChoice = Console.ReadLine();

        if(!Int32.TryParse(userChoice, out num)) continue;

        if (userChoice == "7")
        {
            Environment.Exit(0);
        }

        Console.WriteLine("Choice = " + userChoice);

        if(userChoice == "1")
        {
          Console.WriteLine("What is your account name and starting balance?");
          
            //Some code that will allow me to enter info on the account 
        // it will then display the menu again after all questions are answered.
        }

        if(userChoice == "2")
       {
         
       }

       
  Account account1 = new Account("Mr Will HH", "350", "£2500");
Int16.Parse("350");



    }while (true);
    
        }
}


}




