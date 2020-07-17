using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfClass_Bread()
    {
      Bread newBread = new Bread("French");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetType_ReturnsTypeOfBreadObject_string()
    {
      Bread newBread = new Bread("French");
      string testString = "French";
      Assert.AreEqual(testString, newBread.Type);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfBreadObject_decimal()
    {
      Bread newBread = new Bread("French");
      decimal testNumber = 6;
      Assert.AreEqual(testNumber, newBread.Price);
    }

    [TestMethod]
    public void GetOptions_ReturnsDictionaryOfBreadClass_Dictionary()
    {
      Assert.AreEqual(typeof(Dictionary<string, decimal>), Bread.GetOptions().GetType());
    }

    [TestMethod]
    public void GetBreadTypes_ReturnsListOfBreadTypes_List()
    {
      List<string> testList = Bread.GetBreadTypes();
      Assert.AreEqual("White", testList[0]);
    }

    [TestMethod]
    public void GetBreadPrices_ReturnsListOfBreadPrices_List()
    {
      List<decimal> testList = Bread.GetBreadPrices();
      Assert.AreEqual(5, testList[0]);
    }
  }
}