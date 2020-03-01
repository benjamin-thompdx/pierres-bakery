using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }

    public Bread()
    {
      BreadQuantity = 0;
      BreadPrice = 0;
    }
    
    public void BreadTotal(int breadQuantity, int breadPrice)
    {
      if (breadQuantity == 1)
      {
        breadPrice += 5;
      }
      else
      {
        for(int i = 0; i < breadQuantity; i++)
        {
          if (i % 3 == 0)
          {
            breadPrice += 10;
          }
        }
      }
      Console.WriteLine(breadQuantity + " loaf(s) of bread for $" + breadPrice);
    }
  }
}