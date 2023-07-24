using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string OrderTitle {get; set;}
    public string OrderDescription {get; set;}
    public int OrderPrice {get; set;}
    public int OrderId {get;}
    public OrderDateAndTime Date {get; set;}
    private static List<Order> _instances = new List<Order> {};

    public Order(string orderTitle, string orderDescription, int orderPrice, OrderDateAndTime date)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      Date = date;
      _instances.Add(this);
      OrderId = _instances.Count;
    }
  }
}