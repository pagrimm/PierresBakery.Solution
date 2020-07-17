using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  
  public class Pastry
  {
    public string Type { get; }
    public int Price { get; }
    private Dictionary<string, int> _priceList = new Dictionary<string, int>() { {"Default", 1}, {"Donut", 2} };
    public Pastry(string inputType)
    {
      Type = inputType;
      Price = _priceList[Type];
    }
  }
}