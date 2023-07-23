using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order{

    private static List<Order> _intances = new List<Order> {};

    public string VendorName {get; set;}
    public string VendorDescription {get; set;}
    public int IdNumber {get;}
    public List<VendorOrder> VendorOrder {get; set;}

    public Order(string name, string decription)
    {
      VendorName = name;
      VendorDescription = decription;
      instances.Add(this);
      IdNumber = _instances.Count;
      VendorOrder = new List<VendorOrder>{};
    }
  }
}