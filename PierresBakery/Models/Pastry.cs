using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  
  public class Pastry
  {
    public string Type { get; }
    public Pastry(string inputType)
    {
      Type = inputType;
    }
  }
}