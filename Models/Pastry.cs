using System;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(int pastryQuantity, int pastryPrice)
    {
      PastryQuantity = 0;
      PastryPrice = 2;
    }

    public static void OrderPastery()
    {
      Console.WriteLine ("-----------------");
      Console.WriteLine("Would you like to order pastries? Type 'y' for yes and 'n' for no");
      string userInput = Console.ReadLine().ToLower();
      if (userInput == "y" || userInput == "n")
      {
        if (userInput == "y")
        {
          Console.WriteLine("Enter the number of pastries would you like to buy:");
          // Console.Readline();
        }
        else if (userInput == "n")
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
  }
}