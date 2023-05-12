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
      string testDescribe = "Downtown Location";
      string testAddress = "2037 N First Ave";
      Vendor testVendor = new Vendor(testName, testDescribe, testAddress);
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetVendorProperties_ReturnsVendorProperties_Strings()
    {
      string nameTest = "Donnies";
      string describeTest = "Downtown Location";
      string addressTest = "2037 N First Ave";
      
      Vendor testVendor = new Vendor(nameTest, describeTest, addressTest);
      string resultName = testVendor.Name;
      string resultDescribe = testVendor.Describe;
      string resultAddress = testVendor.Address;
      
      Assert.AreEqual(nameTest, resultName);
      Assert.AreEqual(describeTest, resultDescribe);
      Assert.AreEqual(addressTest, resultAddress);
    }
  }
}    