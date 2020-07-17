using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

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

  }
}