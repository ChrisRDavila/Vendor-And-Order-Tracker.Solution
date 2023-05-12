using System.Collections.Generic;

namespace VendorAndOrderTracker.Models

{
  public class Vendor
  {
    public string Name { get; set; }
    public string Describe { get; set; }
    public string Address { get; set; }
    public int VendorId { get; }
    public List<Order> Orders { get; set; } 
    private static List<Vendor> _instancesVen = new List<Vendor> {};
  

    public Vendor(string name, string describe, string address)
    {
      Name = name; 
      Describe = describe;
      Address = address;
      _instancesVen.Add(this);
      VendorId = _instancesVen.Count;
      Orders = new List<Order>{};
      
    }

    public static void ClearAll()
    {
      _instancesVen.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instancesVen;
    }

    public static Vendor Find(int searchId)
    {
      return _instancesVen[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }




  }
}