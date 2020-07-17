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

    public void AddBread(Bread inputBread, int numberOfTimes)
    {
      for (int i = 0; i < numberOfTimes; i++)
      {
        BreadList.Add(inputBread);
      }
    }

    public void AddPastry(Pastry inputPastry, int numberOfTimes)
    {
      for (int i = 0; i < numberOfTimes; i++)
      {
        PastryList.Add(inputPastry);
      }
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
      return decimal.Round(outputPrice, 2);
    }

    public decimal GetPastryPrice()
    {
      decimal outputPrice = 0;
      Dictionary<string, decimal> pastryPrices = Pastry.GetOptions();
      Dictionary<decimal, decimal> typeCount = new Dictionary<decimal, decimal>();
      foreach(KeyValuePair<string, decimal> entry in pastryPrices)
      {
        if (!typeCount.ContainsKey(entry.Value)) {
          typeCount.Add(entry.Value, 0);
        }
      }
      foreach(Pastry entry in PastryList)
      {
        typeCount[entry.Price] += 1;
      }
      foreach(KeyValuePair<decimal, decimal> entry in typeCount)
      {
        if (entry.Value > 0)
        {
          decimal multiplesOfThree = Math.Floor(entry.Value / 3);
          decimal pricePerThree = (entry.Key * 3m) * (5m / 6m);
          outputPrice += ((multiplesOfThree * pricePerThree) + ((entry.Value - (multiplesOfThree * 3)) * entry.Key));
        }
      }
      return decimal.Round(outputPrice, 2);
    }
  }
}