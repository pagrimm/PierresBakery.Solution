using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    private static Dictionary<string, int> _priceList = new Dictionary<string, int>()
    { 
      {"Default", 1},
      {"Donut", 2} 
    };
    public string Type { get; }
    public int Price { get; }
    public Pastry(string inputType)
    {
      Type = inputType;
      Price = _priceList[Type];
    }

    public static Dictionary<string, int> GetOptions()
    {
      return _priceList;
    }
  }
}