using System.Collections.Generic;
using VendingMachine.interfaces;

namespace VendingMachine.models
{
  class Deus_ex
  {

    public List<IVendItem> DeusX { get; set; } = new List<IVendItem>();

    public string VendNoise { get; private set; } = "vrrrrrr";

    public void Setup()
    {
      Mushroom Mushies = new Mushroom("Magical Mushies", 20.00f, "Whoa man, the vending machine is moving.");
      Towel UsedTowel = new Towel("Used Towel", 9999.99f, "Towel heavily used by Kobe Bryant.");
      Twinky AncientTwinky = new Twinky("Ancient Twinky", .99f, "Ancient Twinky, it's probably still good.");
      EnergyBar ClifBar = new EnergyBar("Clif Bar", 1.99f, "Energy bar harvested from the cliffs of Dover.");
    }
    public Deus_ex()
    {
    }
  }
}