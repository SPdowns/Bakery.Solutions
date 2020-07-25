using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryItem { get; set; }

    public int PastryPrice { get; set; }

    public Pastry(int pastryItem)
    {
      PastryItem = pastryItem;
    }

    public static int PastryTotal(int pastryItem)
    {
      if (pastryItem == 1 || pastryItem == 2)
      {
        return pastryItem*5;
      }
      else if (pastryItem%3 == 2)
      {
        return (pastryItem-2)*5;
      }
      else if (pastryItem == 3 || pastryItem%3 == 1)
      {
        return (pastryItem-1)*5;
      }
      else if (pastryItem%3 == 0)
      {
        return pastryItem*5/3;
      }
      else
      {
        return 404;
      }
    }
  }
}