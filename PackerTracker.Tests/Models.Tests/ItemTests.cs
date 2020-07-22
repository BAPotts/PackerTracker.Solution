using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests
  {
    // Test methods go here
    [TestMethod]
    public void ItemConstructor_ReturnAnItemObject_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
  }
}