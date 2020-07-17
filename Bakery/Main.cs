using System;
using BreadLoaf;
using Pastry;

namespace Bakery
{
  public class OrderUI
  {
    public static void Main()
    {
      Console.WriteLine("Hello User; Welcome to the future of bread ordering!");
      Console.WriteLine("We have two items for sale. Bread and Pastry.");
      Console.WriteLine("How many bread do you want?");
      string stringBreadloafs = Console.ReadLine();
      Console.WriteLine("How many Pastry do you want?");
      string stringPastryItem = Console.ReadLine();

      int breadLoafs = int.Parse(stringBreadloafs);
      int pastryItem = int.Parse(stringPastryItem);

      int total = Bread.breadPrice.BreadTotal();
      Console.WriteLine($"Your order bread total {total}");
    }
  }
}