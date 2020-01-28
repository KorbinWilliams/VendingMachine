using VendingMachine.interfaces;

namespace VendingMachine.models
{
  public class Towel : IVendItem
  {

    public string Name { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public Towel(string name, float price, string description)
    {
      Name = name;
      Price = price;
      Description = description;
    }
  }
}