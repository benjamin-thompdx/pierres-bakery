using System;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }
    public int BreadTotalPrice { get; set; }

    public Bread(int breadQuantity, int breadPrice, int breadTotalPrice)
    {
      BreadQuantity = 0;
      BreadPrice = 5;
    }

  }
}