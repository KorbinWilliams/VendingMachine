using VendingMachine.interfaces;
using VendingMachine.models;

namespace VendingMachine
{
  class EnergyBar : Food, IVendItem
  {
    public string Name { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public EnergyBar(string name, float price, string description)
    {
      Name = name;
      Price = price;
      Description = description;
    }
  }
}