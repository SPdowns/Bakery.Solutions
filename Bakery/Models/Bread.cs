using System.Collections.Generic;
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

    public int BreadTotal(int breadLoafs)
    {
      var breadPrice = this.BreadLoafs * 5;
      return breadPrice;
    }
  }
}