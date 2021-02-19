using Capgemini.Models;
using Capgemini.Services;
using System;
using System.Collections.Generic;

namespace Capgemini
{
    class Program
    {
        static void Main(string[] args)
        {
            var purchasedItems = new List<Item>()
            {
                new Item("Cola", .50m, ItemType.Drink),
                new Item("Coffee", 1.00m, ItemType.Drink),
                new Item("Cheese Sandwich", 2.00m, ItemType.Food),
                new Item("Steak Sandwich", 4.50m, ItemType.Food)
            };

            var bill = BillService.ProduceBill(purchasedItems);

            Console.WriteLine($"Your bill is {string.Format("{0:C}", bill.Total)}");
            Console.ReadLine();
        }
    }
}
