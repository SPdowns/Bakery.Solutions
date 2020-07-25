using System;

namespace Bakery.Models
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