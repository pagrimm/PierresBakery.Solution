using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string Type { get; }
    public int Price { get; }
    private Dictionary<string, int> _priceList = new Dictionary<string, int>() { {"Default", 1}, {"French", 2} };
    public Bread(string inputType)
    {
      Type = inputType;
      Price = _priceList[Type];
    }
  }
}