using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;


namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests

  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      string titleTest = "Weekly Order from Anne";
      string descriptionTest = "3 loaves, 4 croissants";
      int priceTest = 7;
      string dateTest = "Mar 3, 2023";
      Order testOrder = new Order(titleTest, descriptionTest, priceTest, dateTest);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
  }
}    