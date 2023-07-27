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
      OrderTest newOrder = new OrderTest("order", "order list", "month", "day" , "year");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}