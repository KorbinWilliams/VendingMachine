using VendingMachine.interfaces;

namespace VendingMachine.models
{
  public class Twinky : Food, IVendItem
  {
    public string Name { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    private string GetVendItem()
    {
      return $"{Name}: {Price} /n {Description}";
    }
    public Twinky(string name, float price, string description)
    {
      Name = name;
      Price = price;
      Description = description;
    }
  }
}