using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery {
  public class Program
  {
    public static void Main()
    {
      Order newOrder = new Order();
      MainMenu(newOrder);
    }

    public static void MainMenu(Order inputOrder)
    {
      Console.WriteLine("██████╗░██╗███████╗██████╗░██████╗░███████╗██╗░██████╗");
      Console.WriteLine("██╔══██╗██║██╔════╝██╔══██╗██╔══██╗██╔════╝╚█║██╔════╝");
      Console.WriteLine("██████╔╝██║█████╗░░██████╔╝██████╔╝█████╗░░░╚╝╚█████╗░");
      Console.WriteLine("██╔═══╝░██║██╔══╝░░██╔══██╗██╔══██╗██╔══╝░░░░░░╚═══██╗");
      Console.WriteLine("██║░░░░░██║███████╗██║░░██║██║░░██║███████╗░░░██████╔╝");
      Console.WriteLine("╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝░░░╚═════╝░");
      Console.WriteLine("");
      Console.WriteLine("██████╗░░█████╗░██╗░░██╗███████╗██████╗░██╗░░░██╗");
      Console.WriteLine("██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗╚██╗░██╔╝");
      Console.WriteLine("██████╦╝███████║█████═╝░█████╗░░██████╔╝░╚████╔╝░");
      Console.WriteLine("██╔══██╗██╔══██║██╔═██╗░██╔══╝░░██╔══██╗░░╚██╔╝░░");
      Console.WriteLine("██████╦╝██║░░██║██║░╚██╗███████╗██║░░██║░░░██║░░░");
      Console.WriteLine("╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░");
      Console.WriteLine("");
      Console.WriteLine("       ______________________________");
      Console.WriteLine("     / \\          MAIN MENU          \\.");
      Console.WriteLine("    |   |                            |.");
      Console.WriteLine("     \\_ |   Enter 1 to add food      |.");
      Console.WriteLine("        |                            |.");
      Console.WriteLine("        |   Enter 2 to check out     |.");
      Console.WriteLine("        |   _________________________|___");
      Console.WriteLine("        |  /                            /.");
      Console.WriteLine("        \\_/____________________________/.");
      Console.WriteLine("");
      MainCheckInput();
      void MainCheckInput()
      {
        string userInput = Console.ReadLine();
        if (userInput == "1" || userInput == "2")
        {
          if (userInput == "1")
          {
            AddItemsMenu(inputOrder);
          }
        }
        else
        {
          Console.WriteLine("Invalid entry. Please try again");
          MainCheckInput();
        }
      }
    }

    public static void AddItemsMenu(Order inputOrder)
    {
      Console.WriteLine("Enter stuff");
    }
  }
}