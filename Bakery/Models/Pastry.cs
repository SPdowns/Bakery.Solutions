using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryItem { get; set; }

    public Pastry(int pastryItem)
    {
      PastryItem = pastryItem;
    }

    public static int PastryTotal(int pastryItem)
    {
      if (pastryItem%3 == 0)
      {
        return pastryItem/3*5;
      }
      else if (pastryItem%3 == 1)
      {
        return ((pastryItem -1)/3*5)+2;
      }
      else if (pastryItem%3 == 2)
      {
        return ((pastryItem -2)/3*5)+4;
      }
      else
      {
        return 404;
      }
    }
  }
}