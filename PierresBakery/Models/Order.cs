using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    public List<Bread> BreadList { get; }
    public List<Pastry> PastryList { get; }
    public Order()
    {
      BreadList = new List<Bread> {};
      PastryList = new List<Pastry> {};
    }

    public void AddBread(Bread inputBread)
    {
      BreadList.Add(inputBread);
    }

    public void AddPastry(Pastry inputPastry)
    {
      PastryList.Add(inputPastry);
    }

    public decimal GetBreadPrice()
    {
      decimal outputPrice = 0;
      Dictionary<string, decimal> breadPrices = Bread.GetOptions();
      Dictionary<decimal, decimal> typeCount = new Dictionary<decimal, decimal>();
      foreach(KeyValuePair<string, decimal> entry in breadPrices)
      {
        if (!typeCount.ContainsKey(entry.Value)) {
          typeCount.Add(entry.Value, 0);
        }
      }
      foreach(Bread entry in BreadList)
      {
        typeCount[entry.Price] += 1;
      }
      foreach(KeyValuePair<decimal, decimal> entry in typeCount)
      {
        if (entry.Value > 0)
        {
          outputPrice += ((entry.Value - Math.Floor(entry.Value / 3)) * entry.Key);
        }
      }
      return outputPrice;
    }
  }
}