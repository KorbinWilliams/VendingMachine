using System;
using VendingMachine.services;

namespace VendingMachine.controllers
{
  class VendingController
  {
    private VendingService Service { get; set; } = new VendingService();
    private bool _running = true;
    public void Start()
    {
      Service.PrintVendItems();
      while (_running)
      {
        PrintMessages();
        GetUserInput();
      }
    }

    private void PrintMessages()
    {
      foreach (var message in Service.messages)
      {
        Console.WriteLine(message);
      }
    }

    private void GetUserInput()
    {
      var key = Console.ReadKey();
      var keyChar = key.KeyChar;
      Console.Clear();
      switch (keyChar)
      {
        case 'v':
          Console.WriteLine("Which item would you like to vend?");
          var choice = Console.ReadKey();
          var choiceKey = choice.KeyChar;
          Console.WriteLine("Would you like a (C)lif bar, some (M)agic mushrooms, an Ancient (T)winky, or Kobe Bryants T(O)wel?");
          switch (choiceKey)
          {
            case 'C':
              Console.WriteLine("You feel energized.");
              break;
            case 'M':
              Console.WriteLine("You may want to be in a safe place before eating these.");
              break;
            case 'T':
              Console.WriteLine("You now have rations for the Corona virus apocalypse!");
              break;
            case 'O':
              Console.WriteLine("You feel happy, sad, and a little grossed out.");
              break;
            default:
              break;
          }
          break;
        case 'q':
          Console.WriteLine("Goodbye Human.");
          _running = false;
          break;
        default:
          Console.WriteLine("That didn't seem to do anything...");
          break;
      }
    }
  }
}