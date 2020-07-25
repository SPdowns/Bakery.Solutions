using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryItem { get; set; }

    public Pastry(int pastryItem)
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