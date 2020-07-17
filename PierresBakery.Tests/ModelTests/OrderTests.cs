using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfClass_Order()
    {
      Order testOrder = new Order();
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesFieldOfBreadList_List()
    {
      Order testOrder = new Order();
      Assert.AreEqual(typeof(List<Bread>), testOrder.BreadList.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesFieldOfPastryList_List()
    {
      Order testOrder = new Order();
      Assert.AreEqual(typeof(List<Pastry>), testOrder.PastryList.GetType());
    }

    [TestMethod]
    public void AddBread_AddsBreadObjectToOrder_Object()
    {
      Order testOrder = new Order();
      Bread testBread = new Bread("French");
      testOrder.AddBread(testBread);
      Assert.AreEqual(1, testOrder.BreadList.Count);
    }

    [TestMethod]
    public void AddPastry_AddsPastryObjectToOrder_Object()
    {
      Order testOrder = new Order();
      Pastry testPastry = new Pastry("Donut");
      testOrder.AddPastry(testPastry);
      Assert.AreEqual(1, testOrder.PastryList.Count);
    }

  }
}