using System;

namespace Models
{
  public class Pastry
  {
    public string PastryName { get; set; } = "Pastry";
    public int PastryQuantity { get; set; } = 1;
    public int PastryPrice { get; set; } = 2;

    public Pastry(string pastryName, int pastryQuantity, int pastryPrice)
    {
      PastryName = pastryName;
      PastryQuantity = pastryQuantity;
      PastryPrice = pastryPrice;
    }
  }
}