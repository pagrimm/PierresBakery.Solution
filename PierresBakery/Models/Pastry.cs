using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    private static Dictionary<string, decimal> _priceList = new Dictionary<string, decimal>()
    { 
      {"Croissant", 2},
      {"Donut", 2},
      {"Bearclaw", 3},
      {"Strudel", 5},
      {"Baklava", 8}  
    };
    public string Type { get; }
    public decimal Price { get; }
    public Pastry(string inputType)
    {
      Type = inputType;
      Price = _priceList[Type];
    }

    public static Dictionary<string, decimal> GetOptions()
    {
      return _priceList;
    }
  }
}