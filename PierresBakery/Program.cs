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
      Console.WriteLine("");
      Console.WriteLine("");
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
      Console.WriteLine("     \\_ |   Enter 1 to add food.     |.");
      Console.WriteLine("        |                            |.");
      Console.WriteLine("        |   Enter 2 to check out.    |.");
      Console.WriteLine("        |   _________________________|___");
      Console.WriteLine("        |  /                            /.");
      Console.WriteLine("        \\_/____________________________/.");
      Console.WriteLine("");
      MainCheckInput(inputOrder);
    }

    public static void MainCheckInput(Order inputOrder)
    {
      string userInput = Console.ReadLine();
      if (userInput == "1" || userInput == "2")
      {
        if (userInput == "1")
        {
          AddItemsMenu(inputOrder);
        }
        if (userInput == "2")
        {
          DisplayCart(inputOrder);
        }
      }
      else
      {
        Console.WriteLine("Invalid entry. Please try again");
        MainCheckInput(inputOrder);
      }
    }

    public static void AddItemsMenu(Order inputOrder)
    {
      List<string> breadTypes = Bread.GetBreadTypes();
      List<decimal> breadPrices = Bread.GetBreadPrices();
      List<string> pastryTypes = Pastry.GetPastryTypes();
      List<decimal> pastryPrices = Pastry.GetPastryPrices();
      string selectionType;
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Enter 1 to add breads");
      Console.WriteLine("Enter 2 to add pastries");
      BreadOrPastry();
      void BreadOrPastry ()
      {
        string userInput = Console.ReadLine();
        if (userInput == "1")
        {
          AddItemsBreadType();
        }
        else if (userInput == "2")
        {
          AddItemsPastryType();
        }
        else
        {
          Console.WriteLine("Invalid entry. Please try again");
          BreadOrPastry();
        }
      }
      void AddItemsBreadType()
      {
        Console.WriteLine("");
        Console.WriteLine("");
        for (int i = 0; i < breadTypes.Count; i++)
        {
          Console.WriteLine($"Enter {i} for {breadTypes[i]} bread, ${breadPrices[i].ToString("0.00")} per loaf");
        }
        string userInput = Console.ReadLine();
        int userNumber;
        if (int.TryParse(userInput, out userNumber) && userNumber >= 0 && userNumber < breadTypes.Count)
        {
          selectionType = breadTypes[userNumber];
          AddItemsBreadNumber();
        }
        else
        {
          Console.WriteLine("Invalid entry. Please try again");
          AddItemsBreadType();
        }
      }
      void AddItemsPastryType()
      {
        Console.WriteLine("");
        Console.WriteLine("");
        for (int i = 0; i < pastryTypes.Count; i++)
        {
          Console.WriteLine($"Enter {i} for {pastryTypes[i]} pastries, ${pastryPrices[i].ToString("0.00")} per pastry");
        }
        string userInput = Console.ReadLine();
        int userNumber;
        if (int.TryParse(userInput, out userNumber) && userNumber >= 0 && userNumber < breadTypes.Count)
        {
          selectionType = pastryTypes[userNumber];
          AddItemsPastryNumber();
        }
        else
        {
          Console.WriteLine("Invalid entry. Please try again");
          AddItemsPastryType();
        }
      }
      void AddItemsBreadNumber()
      {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("How many would you like?");
        string userInput = Console.ReadLine();
        int userNumber;
        if (int.TryParse(userInput, out userNumber) && userNumber > 0 && userNumber < 100)
        {
          Bread newBread = new Bread(selectionType);
          inputOrder.AddBread(newBread, userNumber);
          Console.WriteLine($"Added x{userNumber} {selectionType} bread to cart");
          MainMenu(inputOrder);
        }
        else
        {
          Console.WriteLine("Invalid entry. Please try again");
          AddItemsBreadNumber();
        }
      }
      void AddItemsPastryNumber()
      {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("How many would you like?");
        string userInput = Console.ReadLine();
        int userNumber;
        if (int.TryParse(userInput, out userNumber) && userNumber > 0 && userNumber < 100)
        {
          Pastry newPastry = new Pastry(selectionType);
          inputOrder.AddPastry(newPastry, userNumber);
          Console.WriteLine($"Added x{userNumber} {selectionType} pastry to cart");
          MainMenu(inputOrder);
        }
        else
        {
          Console.WriteLine("Invalid entry. Please try again");
          AddItemsPastryNumber();
        }
      }
    }

    public static void DisplayCart(Order inputOrder)
    {
      if (inputOrder.BreadList.Count > 0 || inputOrder.PastryList.Count > 0)
      {
        decimal breadTotal = inputOrder.GetBreadPrice();
        decimal pastryTotal = inputOrder.GetPastryPrice();
        decimal totalPrice = breadTotal + pastryTotal;
        Console.WriteLine($"Bread total: ${breadTotal.ToString("0.00")}");
        Console.WriteLine($"Pastry total: ${pastryTotal.ToString("0.00")}");
        Console.WriteLine($"Grand total: ${totalPrice.ToString("0.00")}");
        MainCheckInput(inputOrder);
      }
      else
      {
        Console.WriteLine("Cart is empty. Enter 1 to add food.");
        MainCheckInput(inputOrder);
      }
    }
  }
}