using System;

namespace BreadLoaf
{
  public class Bread
  {
    public int BreadLoafs { get; set; }

    public Bread(int breadLoafs)
    {
      BreadLoafs = breadLoafs;
    }

    public int breadTotal()
    {
      var breadTotal = this.BreadLoafs * 5;
      return breadTotal;
    }
  }
}