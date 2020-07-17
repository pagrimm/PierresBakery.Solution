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
    public void GetPrice_ReturnsPriceOfBreadObject_int()
    {
      Bread newBread = new Bread("French");
      int testInt = 2;
      Assert.AreEqual(testInt, newBread.Price);
    }

    [TestMethod]
    public void GetOptions_ReturnsDictionaryOfBreadClass_Dictionary()
    {
      Assert.AreEqual(typeof(Dictionary<string, int>), Bread.GetOptions());
    }

  }
}