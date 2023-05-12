using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;
using System.Collections.Generic;


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

    [TestMethod]
    public void GetAllVendors_ReturnsAllVendorsObjects_VendorList()
    {
      string testName01 = "Cool Cafe";
      string testDescribe01 = "small cart business";
      string testAddress01 = "1234 Main";
      string testName02 = "Bretts Bread";
      string testDescribe02 = "Large Cafe";
      string testAddress02 = "4321 First";
      Vendor newVendor1 = new Vendor(testName01,testDescribe01,testAddress01);
      Vendor newVendor2 = new Vendor(testName02, testDescribe02, testAddress02);
      List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Cool Cafe";
      string testDescribe01 = "small cart business";
      string testAddress01 = "1234 Main";
      string name02 = "Bretts Bread";
      string testDescribe02 = "Large Cafe";
      string testAddress02 = "4321 First";

      Vendor newVendor1 = new Vendor(name01, testDescribe01, testAddress01);
      Vendor newVendor2 = new Vendor(name02, testDescribe02, testAddress02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string titleTest = "Weekly Order from Anne";
      string descriptionTest = "3 loaves, 4 croissants";
      int priceTest = 7;
      string dateTest = "Mar 3, 2023";
      Order testOrder = new Order(titleTest, descriptionTest, priceTest, dateTest)
      List<Order> newList = new List<Order> { testOrder };
      string testname = "Cool Cafe";
      string testDescribe = "small cart business";
      string testAddress = "1234 Main";
      Vendor newVendor = new Vendor(testname, testDescribe, testAddress);
      newVendor.AddOrder(testOrder);

      //Act
      List<Order> result = newVender.Order;

      //Assert
      CollectionAssert.AreEqual(newList, result);
  }
}    