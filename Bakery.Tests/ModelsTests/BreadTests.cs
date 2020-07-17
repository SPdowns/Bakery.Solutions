using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadLoaf;

namespace BreadLoaf.Tests
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
      Bread newOrder = new Bread(3);
      var breadTotal = newOrder.BreadLoafs * 5;
      Assert.AreEqual(15, breadTotal);
    }
  }
}