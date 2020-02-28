using System;

namespace Models
{
  public class Bread
  {
    public string BreadName { get; set; } = "bread";
    public int BreadQuantity { get; set; } = 1;
    public int BreadPrice { get; set; } = 5;

    public Bread(string breadName, int breadQuantity, int breadPrice)
    {
      BreadName = breadName;
      BreadQuantity = breadQuantity;
      BreadPrice = breadPrice;
    }
  }
}