using System;

namespace Pastry
{
  public class PastryOrder
  {
    public int PastryItem { get; set; }

    public PastryOrder(int pastryItem)
    {
      PastryItem = pastryItem;
    }

    public int PastryTotal()
    {
      var pastryTotal = PastryItem * 2;
      return pastryTotal;
    }
  }
}