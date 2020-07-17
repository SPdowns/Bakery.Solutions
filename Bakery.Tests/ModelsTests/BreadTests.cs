using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadLoaf;

namespace BreadLoaf.Tests
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void AddLoafs_CanInputNumberOfBreadLoafs_True()
    {
      Order newOrder = new Order(3);
      Assert.AreEqual(true, newOrder.Bread == 3);
    }
  }
}