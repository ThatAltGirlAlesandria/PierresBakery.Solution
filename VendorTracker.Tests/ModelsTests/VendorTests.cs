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
      Vendor newVendor = new Vendor("Starbucks", "The Human Bean", "Dutch Brothers");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void RequestNameOfVendor_ReturnsTheNameOfVendor()
    {
      string name = "Starbucks";
      string description = "Cafe";
      VendorTests newVendor = new Vendor(name, description);

      string result = newVendor.

    }
  }
}