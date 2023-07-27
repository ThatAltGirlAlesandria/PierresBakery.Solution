using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("/vendor")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendor/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(vendorId);
      List<Order> orderFromVendor = currentVendor.Order;
      model.Add("vendor", currentVendor);
      model.Add("order", orderFromVendor);
      return View(model);
    }
    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create(int vendorId, string orderName, string orderDescription, int orderPrice, DateTime date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName, orderDescription, orderPrice, date);
      foundVendor.AddOrder(newOrder);
      List<Order> orderFromVendor = foundVendor.Order;
      model.Add("orders", orderFromVendor);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}