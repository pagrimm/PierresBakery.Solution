using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    private static Dictionary<string, decimal> _priceList = new Dictionary<string, decimal>()
    {
      {"Default", 5},
      {"French", 2}
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
  }
}