using VendingMachine.interfaces;

namespace VendingMachine.models
{

  public class Mushroom : Food, IVendItem
  {

    public string Name { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public Mushroom(string name, float price, string description)
    {
      Name = name;
      Price = price;
      Description = description;
    }
  }
}