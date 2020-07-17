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
  }
}