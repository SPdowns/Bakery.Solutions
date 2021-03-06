using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void AddLoafs_CanInputNumberOfBreadLoafs_True()
    {
      Bread newOrder = new Bread(3);
      Assert.AreEqual(true, newOrder.BreadLoafs == 3);
    }

    [TestMethod]
    public void CalcLoafs_CalculatesTotalOFBraodLoafs_Total()
    {
      Bread newOrder = new Bread(17);
      int result = Bread.BreadTotal(17);
      Assert.AreEqual(60, result);
    }
  }
}