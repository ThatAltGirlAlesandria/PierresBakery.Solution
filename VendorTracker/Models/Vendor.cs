using System.Collections.Generic;
using System; 

namespace VendorTracker.Models
{
  public class Vendor{

    private static List<Vendor> _instances = new List<Vendor> {};

    public string VendorName {get; set;}
    public string VendorDescription {get; set;}
    public int Id {get;}
    public List<Order> Order {get; set;}

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Order = new List<Order>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor>GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchVendorId)
    {
      return _instances[searchVendorId-1];
    }
    public void AddNewOrder(Order order)
    {
      Order.Add(order);
    }
  }
}