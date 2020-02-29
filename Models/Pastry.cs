using System;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }
    public int Total { get; set; }

    public Pastry()
    {
      PastryQuantity = 0;
      PastryPrice = 2;
      Total = 0;
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

    // public PastryTotal()
    // {

    // }

  }
}