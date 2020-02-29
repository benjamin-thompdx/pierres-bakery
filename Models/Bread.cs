using System;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }
    public int Total { get; set; }

    public Bread(int breadQuantity, int breadPrice)
    {
      BreadQuantity = 0;
      BreadPrice = 5;
    }

    public static void OrderBread()
    {
      Console.WriteLine("Would you like to order bread? Type 'y' for yes and 'n' for no");
      string userInput = Console.ReadLine().ToLower();
      if (userInput == "y" || userInput == "n")
      {
        if (userInput == "y")
        {
          Console.WriteLine("Enter the number of loaves of bread would you like to buy:");
          // string stringInputBread = Console.ReadLine();
          // int breadQuantity = int.Parse(stringInputBread);
          // Console.WriteLine(breadQuantity);

        }
        else if ( userInput != "n")
        {
          Console.WriteLine("Order refreshed, please enter 'y' for yes or 'n' for no");
          OrderBread();
        }
      }
    }
  }
}