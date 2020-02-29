using System;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public string Name { get; set; }
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(string name)
    {
      Name = name;
      PastryQuantity = 1;
      PastryPrice = 2;
    }

    public void DeterminePastryTotal (string userInput)
    {
      if (userInput == "y")
      {
        AddPastryQuantity();
        AddPastryPrice();
      }
    }

    private void AddPastryQuantity()
    {
      PastryQuantity *= 1;
    }

    private void AddPastryPrice()
    {
      PastryPrice *= 1;
    }

  }
}