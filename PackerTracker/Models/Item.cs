namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public int Weight { get; set; }
    public bool Packed { get; set; }

    public Item(string name, int weight, bool packed)
    {
      Name = name;
      Weight = weight;
      Packed = packed;
    }

  }
}