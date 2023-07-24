using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor{

    private static List<Vendor> _intances = new List<Vendor> {};

    public string VendorName {get; set;}
    public string VendorDescription {get; set;}
    public int VendorId {get;}
    public List<VendorOrder> VendorOrder {get; set;}

    public Order(string vendorName, string vednorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      instances.Add(this);
      VendorId = _instances.Count;
      VendorOrder = new List<VendorOrder>{};
    }
  }
}