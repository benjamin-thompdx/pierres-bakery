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

    public Bread()
    {
      BreadQuantity = 0;
      BreadPrice = 5;
      Total = 0;
    }

    public void DetermineBreadTotal (string userInputB)
    {
      if (userInputB == "y")
      {
        AddBreadQuantity();
        AddBreadPrice();
      }
    }

    private void AddBreadQuantity()
    {
      BreadQuantity *= 1;
    }

    private void AddBreadPrice()
    {
      BreadPrice *= 1;
    }

    // public BreadTotal()
    // {

    // }

  }
}