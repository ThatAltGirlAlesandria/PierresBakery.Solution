using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
  public class Order
  {
    public string OrderTitle {get; set;}
    public string OrderDescription {get; set;}
    public int OrderPrice {get; set;}
    public int Id {get;}
    public DateTime Date {get; set;}
    private static List<Order> _instances = new List<Order> {};

    public Order(string orderTitle, string orderDescription, int orderPrice, DateTime date)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order>GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchOrderId)
    {
      return _instances[searchOrderId-1];
    }
  }
}