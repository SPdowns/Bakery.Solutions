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
      var breadPrice = breadLoafs * 5;
      return breadPrice;
    }
  }
}