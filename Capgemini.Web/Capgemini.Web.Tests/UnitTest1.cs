using Capgemini.Web.Models;
using Capgemini.Web.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void When_Drinks_Then_No_Service_Charge()
        {
            var purchasedItems = new List<Item>()
            {
                new Item("Cola", .50m, ItemType.Drink),
                new Item("Coffee", 1.00m, ItemType.Drink),
                new Item("Cheese Sandwich", 2.00m, ItemType.Drink),
                new Item("Steak Sandwich", 4.50m, ItemType.Drink)
            };

            var bill = BillService.ProduceBill(purchasedItems);

            Assert.AreEqual(8.00m, bill.Total);
        }

        [Test]
        public void FoodDoesIncurServiceCharge()
        {
            var purchasedItems = new List<Item>()
            {
                new Item("Cola", .50m, ItemType.Drink),
                new Item("Coffee", 1.00m, ItemType.Drink),
                new Item("Cheese Sandwich", 2.00m, ItemType.Food),
                new Item("Steak Sandwich", 4.50m, ItemType.Food)
            };

            var bill = BillService.ProduceBill(purchasedItems);

            Assert.AreEqual(8.80m, bill.Total);
        }
    }
}