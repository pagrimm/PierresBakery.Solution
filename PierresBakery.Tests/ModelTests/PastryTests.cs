using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfClass_Pastry()
    {
      Pastry newPastry = new Pastry("Donut");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetType_ReturnsTypeOfPastryObject_string()
    {
      Pastry newPastry = new Pastry("Donut");
      string testString = "Donut";
      Assert.AreEqual(testString, newPastry.Type);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfPastryObject_int()
    {
      Pastry newPastry = new Pastry("Donut");
      int testInt = 2;
      Assert.AreEqual(testInt, newPastry.Price);
    }

    [TestMethod]
    public void GetOptions_ReturnsDictionaryOfPastryClass_Dictionary()
    {
      Assert.AreEqual(typeof(Dictionary<string, int>), Pastry.GetOptions());
    }
    
  }
}