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
      Item newItem = new Item("thing", 1, false);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void TestContructor_ReturnProperties_Item()
    {
      Item newItem = new Item("Tent", 5, true);
      Assert.AreEqual("Tent", newItem.Name);
      Assert.AreEqual(5, newItem.Weight);
      Assert.AreEqual(true, newItem.Packed);
    }
  }
}