using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string Type { get; }
    public Bread(string inputType)
    {
      Type = inputType;
    }
  }
}