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
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesFieldOfBreadList_List()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(List<Bread>), newOrder.BreadList.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesFieldOfPastryList_List()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(List<Pastry>), newOrder.PastryList.GetType());
    }

    /* [TestMethod]
    public void AddBread_AddsBreadObjectToOrder_Object()
    {
      Order newOrder = new Order();
      Bread newBread = new Bread("French");
      newOrder.AddBread(newBread);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    } */

  }
}