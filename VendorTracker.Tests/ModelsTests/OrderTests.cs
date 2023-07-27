using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTest: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void PassOrderConstructor_ToCreate_Order()
    {
      DateTime date = new DateTime(2023, 07, 27);
      Order newOrder = new Order("Starbucks order", "Pastries", 450, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void ReturnsName_String()
    {
      string orderName = "Starbucks";
      string orderDescription = "Pastries";
      int orderPrice = 450;
      DateTime date = new DateTime(2023, 07, 27);

      Order newOrder = new Order(orderName, orderDescription, orderPrice, date);
      string result = newOrder.OrderTitle;

      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string orderName = "Starbucks";
      string orderDescription = "Pastries";
      int orderPrice = 450;
      DateTime date = new DateTime(2023, 07, 27);

      Order newOrder = new Order(orderName, orderDescription, orderPrice, date);
      string result = newOrder.OrderDescription;

      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void GetsOrderPrice_ReturnsOrderPrice_Int()
    {
            string orderName = "Starbucks";
      string orderDescription = "Pastries";
      int orderPrice = 450;
      DateTime date = new DateTime(2023, 07, 27);

      Order newOrder = new Order(orderName, orderDescription, orderPrice, date);
      int result = newOrder.OrderPrice;
      
      Assert.AreEqual(orderPrice, result);
    }

        [TestMethod]
    public void GetsOrderDate_ReturnsOrderDate_DateTime()
    {
      string orderName = "Starbucks";
      string orderDescription = "Pastries";
      int orderPrice = 450;
      DateTime date = new DateTime(2023, 07, 27);

      Order newOrder = new Order(orderName, orderDescription, orderPrice, date);
      DateTime result = newOrder.Date;
      
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrdersForVendor_OrderList()
    {
      string orderName1 = "Starbucks";
      string orderDescription1 = "Pastries";
      int orderPrice1 = 450;
      DateTime date1 = new DateTime(2023, 07, 27);
      string orderName2 = "Dutchies";
      string orderDescription2 = "Pastries";
      int orderPrice2 = 45;
      DateTime date2 = new DateTime(2023, 08, 27);
      Order newOrder1 = new Order(orderName1, orderDescription1, orderPrice1, date1);
      Order newOrder2 = new Order(orderName2, orderDescription2, orderPrice2, date2);
      List<Order> newOrderList = new List<Order> {newOrder1, newOrder2};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrderList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderName1 = "Starbucks";
      string orderDescription1 = "Pastries";
      int orderPrice1 = 450;
      DateTime date1 = new DateTime(2023, 07, 27);
      string orderName2 = "Dutchies";
      string orderDescription2 = "Pastries";
      int orderPrice2 = 45;
      DateTime date2 = new DateTime(2023, 08, 27);
      Order newOrder1 = new Order(orderName1, orderDescription1, orderPrice1, date1);
      Order newOrder2 = new Order(orderName2, orderDescription2, orderPrice2, date2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}