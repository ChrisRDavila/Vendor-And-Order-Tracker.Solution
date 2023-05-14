using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;


namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable

  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      string titleTest = "Weekly Order from Anne";
      string descriptionTest = "3 loaves, 4 croissants";
      decimal priceTest = 7;
      string dateTest = "Mar 3, 2023";
      Order testOrder = new Order(titleTest, descriptionTest, priceTest, dateTest);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetOrderProperties_ReturnsOrderProperties_StringandInt()
    {
      string titleTest = "Weekly Order from Anne";
      string descriptionTest = "3 loaves, 4 croissants";
      decimal priceTest = 7;
      string dateTest = "Mar 3, 2023";
      
      Order testOrder = new Order(titleTest, descriptionTest, priceTest, dateTest);
      string resultTitle = testOrder.Title;
      string resultDescription = testOrder.Description;
      decimal resultPrice = testOrder.Price;
      string resultDate = testOrder.Date;
      
      Assert.AreEqual(titleTest, resultTitle);
      Assert.AreEqual(descriptionTest, resultDescription);
      Assert.AreEqual(priceTest, resultPrice);
      Assert.AreEqual(dateTest, resultDate);
    }

    [TestMethod]
    public void SetOrderProperties_SetsOrderProperties_StringandInt()
    {
      string titleTest = "Weekly Order from Anne";
      string descriptionTest = "3 loaves, 4 croissants";
      decimal priceTest = 7;
      string dateTest = "Mar 3, 2023";
      
      Order testOrder = new Order(titleTest, descriptionTest, priceTest, dateTest);
      string updatedTitle = "Bimonthly order from Freds";
      string updatedDescription = "4 loaves, 2 croissants";
      decimal updatedPrice = 9;
      string updatedDate = "Feb 9, 2003";
      testOrder.Title = updatedTitle;
      testOrder.Description = updatedDescription;
      testOrder.Price = updatedPrice;
      testOrder.Date = updatedDate;
      string resultTitle = testOrder.Title;
      string resultDescription = testOrder.Description;
      decimal resultPrice = testOrder.Price;
      string resultDate = testOrder.Date;
      
      Assert.AreEqual(updatedTitle, resultTitle);
      Assert.AreEqual(updatedDescription, resultDescription);
      Assert.AreEqual(updatedPrice, resultPrice);
      Assert.AreEqual(updatedDate, resultDate);
    }
    [TestMethod]
    public void GetList_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAllLists_ReturnsAllList_OrderList()
    {
      // Arrange
      string title01 = "Weekly Order from Anne";
      string description01 = "3 loaves, 4 croissants";
      decimal price01 = 7;
      string date01 = "Mar 3, 2023";
      string title02 = "monthly Order from Al";
      string description02 = "4 loaves, 5 croissants";
      decimal price02 = 9;
      string date02 = "May 7, 2023";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> {newOrder1, newOrder2 };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetOrderId_ReturnsOrderId_Int()
    {
    //Arrange
    string titleTest = "Weekly Order from Anne";
      string descriptionTest = "3 loaves, 4 croissants";
      decimal priceTest = 7;
      string dateTest = "Mar 3, 2023";
      Order testOrder = new Order(titleTest, descriptionTest, priceTest, dateTest);

      int result = testOrder.OrderId;

      Assert.AreEqual(1, result);
    }

    public void FindOrder_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title01 = "Weekly Order from Anne";
      string description01 = "3 loaves, 4 croissants";
      decimal price01 = 7;
      string date01 = "Mar 3, 2023";
      string title02 = "monthly Order from Al";
      string description02 = "4 loaves, 5 croissants";
      decimal price02 = 9;
      string date02 = "May 7, 2023";

      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

  }  
}    