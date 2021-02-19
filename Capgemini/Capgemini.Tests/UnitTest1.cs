using Capgemini.Models;
using Capgemini.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BillService_ProduceBill_IncursServiceChargeForFood()
        {
            var purchasedItems = new List<Item>()
            {
                new Item("Cola", .50m, ItemType.Drink),
                new Item("Coffee", 1.00m, ItemType.Drink),
                new Item("Cheese Sandwich", 2.00m, ItemType.Food),
                new Item("Steak Sandwich", 4.50m, ItemType.Food)
            };

            var bill = BillService.ProduceBill(purchasedItems);

            Assert.IsTrue(bill.Total > purchasedItems.Sum(x => x.Price));
        }
    }
}