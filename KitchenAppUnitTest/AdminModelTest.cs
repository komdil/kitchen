using KitchenApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
namespace KitchenAppUnitTest
{
    [TestClass]
    public class AdminModelTest
    {
        [TestMethod]
        public void SelectMenu()
        {
            Admin admin = new Admin();
            Menu menu = new Menu() { Id = new System.Guid(), Name = "plov" };
            admin.SelectMenuForToday(menu);
            Assert.AreEqual(1, menu.Orders.Count, "If menu choosed, we must create Order object and list of orders in Menu class should be equal to 1");
            Order order = menu.Orders.Single(d=>d.Date==DateTime.Today);
            Assert.AreEqual(menu, order.Menu, "Field Menu of Order class must be equal to choosed menu!");
            Assert.AreEqual(0, order.PeopleCount, "When Order created count of people, who choosed this menu should be equal to 0");
            Assert.AreEqual(false, order.IsClosed, "When Order created Closed field should be false");
        }

        [TestMethod]
        public void CloseOrderTest()
        {
            Admin admin = new Admin();
            Menu menu = new Menu() { Id = new System.Guid(), Name = "plov" };
            admin.SelectMenuForToday(menu);
            admin.CloseOrderOfToday();
            Order order = menu.Orders.Single();
            Assert.IsFalse(order.IsClosed, "Order should be opened opened!");
        }

        [TestMethod]
        public void SetPrice()
        {
            Admin admin = new Admin();
            decimal price = 105.20M;
            admin.SetPrice(price);

            Assert.IsNotNull(admin.Details.FirstOrDefault(), "We should have OrderDetails to get Order!");
            Assert.IsNotNull(admin.Details.FirstOrDefault().Order, "We should have created order to which we can set price!");
            Assert.AreEqual(price, admin.Details.FirstOrDefault().Order.Price, "Price should be equal to setted value!");
        }

        [TestMethod]
        public void AddPayment()
        {
            Admin admin = new Admin();
            User user = new User();
            decimal amount = 10.50M;
            admin.AddPayment(user, amount);

            Assert.IsTrue(admin.Payments.Any(x => x.User == user && x.Amount == amount), "If user payed, this info should saved in list of payments!");
        }
    }
}