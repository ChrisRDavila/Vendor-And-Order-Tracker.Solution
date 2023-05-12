using System.Collections.Generic;

namespace VendorAndOrderTracker.Models

{
  public class Vendor
  {
    public string Name { get; set; }
    public string Describe { get; set; }
    public string Address { get; set; }
    public List<Order> Orders { get; set; } 
  

    public Vendor(string name, string describe, string address)
    {
      Name = name; 
      Describe = describe;
      Address = address;
      Orders = new List<Order>{};
    }
  }
}