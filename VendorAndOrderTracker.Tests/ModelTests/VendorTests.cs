using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;


namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests

  {
    [TestMethod]
    public void VendorConstructor_CreatesVendorInstance_Vencor()
    {
      Vendor testVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}    