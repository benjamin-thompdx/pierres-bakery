using System;

namespace Models
{
  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }

    public Pastry()
    {
      PastryQuantity = 0;
      PastryPrice = 2;
    }

    private void AddPastry()
    {
      PastryQuantity += 1;
    }
  }
}