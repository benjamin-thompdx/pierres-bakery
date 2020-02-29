using System;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string Name { get; set; }
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }

    public Bread(string name)
    {
      Name = name;
      BreadQuantity = 1;
      BreadPrice = 5;
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

  }
}