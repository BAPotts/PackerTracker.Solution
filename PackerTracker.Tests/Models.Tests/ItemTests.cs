using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;
using System.Collections.Generic;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
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

    [TestMethod]
    public void GetAll_AddsItemtoList_List()
    { 
      List<Item> _items = new List<Item> {}; // instantiates an empty list
      List<Item> result = Item.GetAll(); // instantiates a list with whatever items have been created with the item class
      CollectionAssert.AreEqual(_items, result);
    }
  }
}