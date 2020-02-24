using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Bank
{
  class Program
  {
    static void Main(string[] args)
    {
      // download csv package
      //As a user I should be able see the totals in my saving and checking account when the program first starts


      //var userDisplay = accountInfo

      var newAccountTracker = new AccountTracker();
      var Account = newAccountTracker.AccountReader();

      var bankStatus = true;
      while (bankStatus)
      {
        //foreach (var s in AccountTracker.account) ;

        Console.WriteLine("What is your checking?");
        var checkNumber = Console.ReadLine();
        Console.WriteLine("How much is in your savings");
        var savingsNumber = Console.ReadLine();
        Console.WriteLine("What is your account number?");
        var account = Console.ReadLine();
        Console.WriteLine($"Your totals are 'checking' and 'savings");
        Console.WriteLine($"What would you like to do (withdraw),(deposit), (transfer), (log out)?");
        var bankRequest = Console.ReadLine().ToLower();
        if (bankRequest == "log out")
        {
          bankStatus = false;
        }
        else if (bankRequest == "withdraw")
        {
          Console.WriteLine("checking or savings");
          var accountChoice = Console.ReadLine().ToLower();
          if (accountChoice == "checking")
          {
            Console.WriteLine("how much");
            var withdrawCheck = Console.ReadLine();
          }
          else
          {
            Console.WriteLine("how much");
            var withdrawSaves = Console.ReadLine();
          }
        }
        else if (bankRequest == "deposit")
        {
          Console.WriteLine("checking or savings");
          var accountChoice = Console.ReadLine().ToLower();
          if (accountChoice == "checking")
          {
            Console.WriteLine("how much");
            var depositCheck = Console.ReadLine();
          }
          else
          {
            Console.WriteLine("how much");
            var depositSaves = Console.ReadLine();
          }
        }
        else if (bankRequest == "transfer")
        {
        }
      }

      //As a user I should be able to deposit funds to my savings account
      //As a user I should be able to deposit funds to my checking account
      //As a user I should be able to withdraw funds to my savings account
      //As a user I should be able to withdraw funds to my checking account
      //As a user I should be able to transfer funds from my checking account to my savings account
      //As a user I should be able to transfer funds from my savings account to my checking accounts
      //The app should save my transactions to file using a standard format. This saving should happen after every transaction
      //The app should load up past transaction from a file on start up.
    }
  }
}
