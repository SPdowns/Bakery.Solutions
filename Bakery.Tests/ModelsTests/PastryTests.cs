using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  
  public class PastryItemsTest
  {
    [TestMethod]
    public void Pastry_CanInputPastryItems_True()
    {
      Pastry newOrder = new Pastry(10);
      Assert.AreEqual(true, newOrder.PastryItem == 10);
    }

    [TestMethod]
    public void Pastry_CalculatesTotalOfPastry_Total()
    {
      Pastry newOrder = new Pastry(17);
      int result = Pastry.PastryTotal(17);
      Assert.AreEqual(29, result);
    }
  }
}