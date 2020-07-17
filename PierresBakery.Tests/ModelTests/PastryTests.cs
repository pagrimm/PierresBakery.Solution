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
    public void GetPrice_ReturnsPriceOfPastryObject_decimal()
    {
      Pastry newPastry = new Pastry("Donut");
      decimal testNumber = 2;
      Assert.AreEqual(testNumber, newPastry.Price);
    }

    [TestMethod]
    public void GetOptions_ReturnsDictionaryOfPastryClass_Dictionary()
    {
      Assert.AreEqual(typeof(Dictionary<string, decimal>), Pastry.GetOptions().GetType());
    }
    
    [TestMethod]
    public void GetPastryTypes_ReturnsListOfPastryTypes_List()
    {
      List<string> testList = Pastry.GetPastryTypes();
      Assert.AreEqual("Croissant", testList[0]);
    }

    [TestMethod]
    public void GetPastryPrices_ReturnsListOfPastryPrices_List()
    {
      List<decimal> testList = Pastry.GetPastryPrices();
      Assert.AreEqual(2, testList[0]);
    }
  }
}