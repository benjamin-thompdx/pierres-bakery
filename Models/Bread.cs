using System;

namespace Models
{
  public class Bread
  {
    public string BreadName { get; set; }
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }

    public Bread(string breadName, int breadQuantity, int breadPrice)
    {
      BreadName = "bread";
      BreadQuantity = 0;
      BreadPrice = 0;
    }

    public void UpdateBreadOrder()
    {
      AddBreadToOrder();
    }

    private void AddBreadToOrder()
    {
      BreadQuantity += 1;
      BreadPrice += 5;
    }

  }
}