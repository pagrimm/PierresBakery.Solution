using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    private static Dictionary<string, decimal> _priceList = new Dictionary<string, decimal>()
    {
      {"White", 5},
      {"French", 6},
      {"Wheat", 6},
      {"Rye", 7},
      {"Banana", 8}
    };
    public string Type { get; }
    public decimal Price { get; }
    public Bread(string inputType)
    {
      Type = inputType;
      Price = _priceList[Type];
    }

    public static Dictionary<string, decimal> GetOptions()
    {
      return _priceList;
    }

    public static List<string> GetBreadTypes()
    {
      List<string> outputList = new List<string>();
      foreach(KeyValuePair<string, decimal> entry in _priceList)
      {
        outputList.Add(entry.Key);
      }
      return outputList;
    }

    public static List<decimal> GetBreadPrices()
    {
      List<decimal> outputList = new List<decimal>();
      foreach(KeyValuePair<string, decimal> entry in _priceList)
      {
        outputList.Add(entry.Value);
      }
      return outputList;
    }
  }
}