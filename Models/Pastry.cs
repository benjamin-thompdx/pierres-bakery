using System;

namespace Models
{
  public class Pastry
  {
    public string PastryName { get; set; }
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(string pastryName, int pastryQuantity, int pastryPrice)
    {
      PastryName = pastryName;
      PastryQuantity = pastryQuantity;
      PastryPrice = pastryPrice;
    }
  }
}