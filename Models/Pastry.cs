using System;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }

    public Pastry()
    {
      PastryQuantity = 0;
      PastryPrice = 0;
    }

    public void PastryTotal(int pastryQuantity, int pastryPrice)
    {
      if (pastryQuantity == 1)
      {
        pastryPrice += 2;
      }
      else
      {
        for(int i = 0; i < pastryQuantity; i++)
        {
          if (i % 3 == 0)
          {
            pastryPrice += 5;
          }
        }
      }
      Console.WriteLine(pastryQuantity + " loaf(s) of bread for $" + pastryPrice);
    }
  }
}