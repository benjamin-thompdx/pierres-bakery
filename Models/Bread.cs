using System;

namespace Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }
    public int BreadTotalPrice { get; set; }


    public Bread()
    {
      BreadQuantity = 0;
      BreadPrice = 5;
      BreadTotalPrice = 0;
    }

    public void BreadOrder(int intBreadInput)
    {
      AddBread(intBreadInput);
      BreadCost();
    }

    private void AddBread(int intBreadInput)
    {
      BreadQuantity += intBreadInput;
    }

    private void BreadCost()
    {
      BreadTotalPrice = BreadPrice * BreadQuantity;
    }

  }
}