using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests 
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Clear()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void PassVendorConstructor_ToCreate_Vendor()
    {
      Vendor newVendor = new Vendor("Starbucks", "The Human Bean", "Dutch Brothers");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}