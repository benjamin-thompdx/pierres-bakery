using System;

namespace Models
{
  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }

    public Pastry()
    {
      PastryName = "pastry";
      PastryQuantity = 0;
      PastryPrice = 0;
    }

    private void AddPastry()
    {
      PastryQuantity += 1;
      PastryPrice += 2;
    }
  }
}