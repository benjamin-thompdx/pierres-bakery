using System;
using Models;

namespace PierresBakery
{
  public class Program
  {
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
      OrderBread();
      OrderPastery();
      OrderTotal();
    } 
      public static void OrderBread()
      {
        Console.WriteLine("Would you like to order bread? Type 'y' for yes and 'n' for no");
         string userInputBread = Console.ReadLine().ToLower();
        if (userInputBread == "y" || userInputBread == "n")
        {
          if (userInputBread == "y")
          {
            Console.WriteLine("Enter the number of loaves of bread would you like to buy:");
            string stringBreadInput = Console.ReadLine();
            int intBreadInput = int.Parse(stringBreadInput);
          }
          else if ( userInputBread != "n")
          {
            Console.WriteLine("Order refreshed, please enter 'y' for yes or 'n' for no");
            OrderBread();
          }
        }
        else
        {
          OrderPastery();
        }
      }
      public static void OrderPastery()
      {
        Console.WriteLine ("-----------------");
        Console.WriteLine("Would you like to order pastries? Type 'y' for yes and 'n' for no");
        string userInputPastry = Console.ReadLine().ToLower();
        if (userInputPastry == "y" || userInputPastry == "n")
        {
          if (userInputPastry == "y")
          {
            Console.WriteLine("Enter the number of pastries would you like to buy:");
            //Console.Readline();
          }
          else if (userInputPastry == "n")
          {
            Console.WriteLine("Thank you for visiting - We look forward to doing business with you in the future!");
          }
        }
        else 
        {
          Console.WriteLine("Order refreshed, please enter 'y' for yes or 'n' for no");
          OrderPastery();
        }
      }
      public static void OrderTotal()
      {
        Console.WriteLine ("-----------------");
        Console.WriteLine("Order Summary:");
      }
  }
}