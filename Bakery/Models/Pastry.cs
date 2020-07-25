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
        return pastryItem * 2;
      }
      else if (pastryItem == 3)
      {
        return (pastryItem * 2) - 1;
      }
      else if (pastryItem % 3 == 2)
      {
        return (((pastryItem -2)/3)*2)+4;
      }
      else if 
      {

      }
      else
      {
        return 404;
      }
    }
  }
}