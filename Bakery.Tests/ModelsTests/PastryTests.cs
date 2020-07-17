using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pastry;

namespace Pastry.Test
{
  [TestClass]
  
  public class PastryItemsTest
  {
    [TestMethod]
    public void Pastry_CanInputPastryItems_True()
    {
      PastryOrder newOrder = new PastryOrder(10);
      Assert.AreEqual(true, newOrder.PastryItem == 10);
    }
  }
}