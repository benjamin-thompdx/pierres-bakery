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
      BreadName = breadName;
      BreadQuantity = breadQuantity;
      BreadPrice = breadPrice;
    }
  }
}