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

  }
}