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
      PastryName = "pastry";
      PastryQuantity = 0;
      PastryPrice = 0;
    }

    public void UpdatePastryOrder()
    {
      AddPastryToOrder();
    }

    private void AddPastryToOrder()
    {
      PastryQuantity += 1;
      PastryPrice += 2;
    }
  }
}