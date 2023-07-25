using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor{

    private static List<Vendor> _intances = new List<Vendor> {};

    public string VendorName {get; set;}
    public string VendorDescription {get; set;}
    public int VendorId {get;}
    public List<VendorOrder> VendorOrder {get; set;}

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      instances.Add(this);
      VendorId = _instances.Count;
      VendorOrder = new List<VendorOrder>{};
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