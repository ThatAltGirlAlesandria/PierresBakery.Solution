using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void PassVendorConstructor_ToCreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Starbucks", "Cafe");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void RequestNameOfVendor_ReturnsTheNameOfVendor()
    {
      string name = "Starbucks";
      string description = "Cafe";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.VendorName;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsTheVendorsId_Int()
    {
      string name = "Starbucks";
      string description = "Cafe";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllObjects_VendorDetails()
    {
      string name1 = "Starbucks";
      string description1= "Cafe";
      string name2 = "Dutchies";
      string description2 = "Cafe";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_LinksVendorWithOrders_OrderList()
    {
      string orderName = "Starbucks";
      string orderDescription = "Pastries";
      int orderPrice = 450;
      DateTime date = new DateTime(2023, 07, 27);
      Order newOrder = new Order(orderName, orderDescription, orderPrice, date);
      List<Order> newList = new List<Order> {newOrder};
      string name = "Starbucks";
      string description = "Cafe";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Order;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}