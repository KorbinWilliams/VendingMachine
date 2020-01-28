namespace VendingMachine.interfaces
{
  interface IVendItem
  {
    string Name { get; set; }
    float Price { get; set; }
    string Description { get; set; }

  }
}