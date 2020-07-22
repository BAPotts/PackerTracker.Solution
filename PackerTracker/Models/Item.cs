using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public int Weight { get; set; }
    public bool Packed { get; set; }
    private static List<Item> _items = new List<Item> {};
    public Item(string name, int weight, bool packed)
    {
      Name = name;
      Weight = weight;
      Packed = packed;
      _items.Add(this); // I believe "this" is referring to the Item constructor?
    }

    public static List<Item> GetAll()
    {
      return _items;
    }
    public static void ClearAll()
    {
      _items.Clear();
    }

  }
}