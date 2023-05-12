using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;


namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable

  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void SetVendorProperties_SetsVendorProperties_Strings()
    {
      string nameTest = "Donnies";
      string describeTest = "Downtown Location";
      string addressTest = "2037 N First Ave";
      
      Vendor testVendor = new Vendor(nameTest, describeTest, addressTest);
      string updatedName = "Cool Cafe";
      string updatedDescribe = "small cart business";
      string updatedAddress = "1234 Main";
      testVendor.Name = updatedName;
      testVendor.Describe = updatedDescribe;
      testVendor.Address = updatedAddress;
      string resultName = testVendor.Name;
      string resultDescribe = testVendor.Describe;
      string resultAddress = testVendor.Address;
      
      Assert.AreEqual(updatedName, resultName);
      Assert.AreEqual(updatedDescribe, resultDescribe);
      Assert.AreEqual(updatedAddress, resultAddress);
    }

    [TestMethod]
    public void GetVendorId_ReturnsVendorId_Int()
    {
    //Arrange
    string nameTest = "Donnies";
    string describeTest = "Downtown Location";
    string addressTest = "2037 N First Ave";
    Vendor testVendor = new Vendor(nameTest, describeTest, addressTest);

    int result = testVendor.VendorId;

    Assert.AreEqual(1, result);
    }
  }
}    