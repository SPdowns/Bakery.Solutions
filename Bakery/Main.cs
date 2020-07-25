using System;
using Bakery.Models;

namespace Bakery
{
  public class OrderUI
  {
    public static void Main()
    {
      Console.WriteLine(@" ______  __   ______   ______   ______   ______   ______       ______   ______   __  __   ______   ______   __  __    ");
      Console.WriteLine(@"/\  == \/\ \ /\  ___\ /\  == \ /\  == \ /\  ___\ /\  ___\     /\  == \ /\  __ \ /\ \/ /  /\  ___\ /\  == \ /\ \_\ \   ");
      Console.WriteLine(@"\ \  _-/\ \ \\ \  __\ \ \  __< \ \  __< \ \  __\ \ \___  \    \ \  __< \ \  __ \\ \  _'-.\ \  __\ \ \  __< \ \____ \  ");
      Console.WriteLine(@" \ \_\   \ \_\\ \_____\\ \_\ \_\\ \_\ \_\\ \_____\\/\_____\    \ \_____\\ \_\ \_\\ \_\ \_\\ \_____\\ \_\ \_\\/\_____\ ");
      Console.WriteLine(@"  \/_/    \/_/ \/_____/ \/_/ /_/ \/_/ /_/ \/_____/ \/_____/     \/_____/ \/_/\/_/ \/_/\/_/ \/_____/ \/_/ /_/ \/_____/ ");
      Console.WriteLine(@"                                                                                                                      ");
      Console.WriteLine("Hello User; Welcome to the future of bread ordering!");
      Console.WriteLine("We have two items for sale. Bread and Pastry.");
      Console.WriteLine("Bread is $5 and is on a Buy 2 Get 1 FREE special!");
      Console.WriteLine("How many bread do you want?");
      string stringBreadLoafs = Console.ReadLine();
      Console.WriteLine("Pastries are Buy 1 for $2 or 3 for $5");
      Console.WriteLine("How many Pastry do you want?");
      string stringPastryItem = Console.ReadLine();

      int userBreadLoafs = int.Parse(stringBreadLoafs);
      int pastryItem = int.Parse(stringPastryItem);

      Bread userBread = new Bread(userBreadLoafs);
      int breadTotal = Bread.BreadTotal(userBreadLoafs);
      Pastry userPastry = new Pastry(pastryItem);
      int pastryTotal = Pastry.PastryTotal(pastryItem);
      Console.WriteLine($"Your order bread total {breadTotal} and your pastry total is {pastryTotal}");
    }
  }
}