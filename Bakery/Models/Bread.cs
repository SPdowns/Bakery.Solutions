using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadLoafs { get; set; }
    public Bread(int breadLoafs)
    {
      BreadLoafs = breadLoafs;
    }
    public static int BreadTotal(int breadLoaf)
    {
      if (breadLoaf == 1 || breadLoaf == 2)
      {
        return breadLoaf*5;
      }
      else if (breadLoaf == 3)
      {
        return (breadLoaf-1)*5;
      }
      else if (breadLoaf%3 == 2)
      {
        return ((((breadLoaf-2)/3)*2)*5)+10;
      }
      else if (breadLoaf%3 == 1)
      {
        return ((((breadLoaf-1)/3)*2)*5)+5;
      }
      else if (breadLoaf%3 == 0)
      {
        return breadLoaf/3*2*5;
      }
      else
      {
        return 404;
      }
    }
  }
}