using System;

namespace Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }

    public Bread()
    {
      BreadName = "bread";
      BreadQuantity = 0;
      BreadPrice = 0;
    }

    private void AddBread()
    {
      BreadQuantity += 1;
      BreadPrice += 5;
    }

  }
}