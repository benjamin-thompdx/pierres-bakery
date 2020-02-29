using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    static string userInputB;
    static string userInputP;
    static Bread breadInput = new Bread(userInputB);
    static Pastry pastryInput = new Pastry(userInputP);

    public static void Main()
    {
      Console.WriteLine(@"     ____  _                    _          ____        __                  
   / __ \(_)__  _____________ ( )_____   / __ )____ _/ /_____  _______  __
  / /_/ / / _ \/ ___/ ___/ _ \|// ___/  / __  / __ `/ //_/ _ \/ ___/ / / /
 / ____/ /  __/ /  / /  /  __/ (__  )  / /_/ / /_/ / ,< /  __/ /  / /_/ / 
/_/   /_/\___/_/  /_/   \___/ /____/  /_____/\__,_/_/|_|\___/_/   \__, /  
                                                                 /____/   ");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bakery Menu: Bread $5 and Pastry $2");
      Console.WriteLine("Current Specials --> Bread: Buy 2, Get 1 Free | Pastries: Buy 3 for $5");
      Console.WriteLine ("-----------------");
      
      Console.WriteLine("Would you like to order bread? Type 'y' for yes and 'n' for no");
      userInputB = Console.ReadLine().ToLower();

      Console.WriteLine("Would you like to order pastry(s)? Type 'y' for yes and 'n' for no");
      userInputP = Console.ReadLine().ToLower();
      
      Console.WriteLine ("-----------------");
      Console.WriteLine("Order Summary:");
      
      breadInput.DetermineBreadTotal(userInputB);
      Console.WriteLine(breadInput.BreadQuantity + " loaf(s) of bread for $" + breadInput.BreadPrice);
      
      pastryInput.DeterminePastryTotal(userInputP);
      Console.WriteLine(pastryInput.PastryQuantity + " pastry(s) for $" + pastryInput.PastryPrice);
    } 
      // public static void OrderBread()
      // {
      //   Console.WriteLine("Would you like to order bread? Type 'y' for yes and 'n' for no");
      //   string userInput = Console.ReadLine().ToLower();
      //   if (userInput == "y" || userInput == "n")
      //   {
      //     if (userInput == "y")
      //     {
      //       Console.WriteLine("Enter the number of loaves of bread would you like to buy:");
      //       // string stringInputBread = Console.ReadLine();
      //       // int intInputBread = int.Parse(stringInputBread);

      //     }
      //     else if ( userInput != "n")
      //     {
      //       Console.WriteLine("Order refreshed, please enter 'y' for yes or 'n' for no");
      //       OrderBread();
      //     }
      //   }
      //   else
      //   {
      //     OrderPastery();
      //   }
      // }

      // public static void OrderPastery()
      // {
      //   Console.WriteLine ("-----------------");
      //   Console.WriteLine("Would you like to order pastries? Type 'y' for yes and 'n' for no");
      //   string userInput = Console.ReadLine().ToLower();
      //   if (userInput == "y" || userInput == "n")
      //   {
      //     if (userInput == "y")
      //     {
      //       Console.WriteLine("Enter the number of pastries would you like to buy:");
      //       // Console.Readline();
      //     }
      //     else if (userInput == "n")
      //     {
      //       Console.WriteLine("Thank you for visiting - We look forward to doing business with you in the future!");
      //     }
      //   }
      //   else 
      //   {
      //     Console.WriteLine("Order refreshed, please enter 'y' for yes or 'n' for no");
      //     OrderPastery();
      //   }
      // }

      // public static void OrderTotal()
      // {
      //   Console.WriteLine ("-----------------");
      //   Console.WriteLine("Order Summary:");
  }
}