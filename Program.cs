using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    static string userInputB;
    static string userInputP;
    static Bread breadInput = new Bread();
    static Pastry pastryInput = new Pastry();

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
      if (userInputB == "y")
      {
        Console.WriteLine("Enter the number of loaves of bread you would like to buy:");
        string breadQuantityTemp = Console.ReadLine();
        int userQuantityB = int.Parse(breadQuantityTemp);
        int breadPrice = 0;
        Console.WriteLine ("-----------------");
        Console.WriteLine("Order Summary:");
        breadInput.BreadTotal(userQuantityB, breadPrice);
      }
      Console.WriteLine("Would you like to order pastry(s)? Type 'y' for yes and 'n' for no");
      userInputP = Console.ReadLine().ToLower();
      if (userInputP == "y")
      {
        Console.WriteLine("Enter the number of pastries you would like to buy:");
        string pastryQuantityTemp = Console.ReadLine();
        int userQuantityP = int.Parse(pastryQuantityTemp);
        int pastryPrice  = 0;
        Console.WriteLine ("-----------------");
        Console.WriteLine("Order Summary:");
        pastryInput.PastryTotal(userQuantityP, pastryPrice);
      }
      Console.WriteLine("Thank you for visiting - We look forward to doing business with you in the future!");
    }
  }
}