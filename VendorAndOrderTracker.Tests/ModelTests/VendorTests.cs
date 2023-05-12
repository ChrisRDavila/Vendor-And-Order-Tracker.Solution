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
      string testName = "Donnies";
      string testDescribe = "Downtown Locaation";
      string testAddress = "2037 N First Ave";
      Vendor testVendor = new Vendor(testName, testDescribe, testAddress);
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}    