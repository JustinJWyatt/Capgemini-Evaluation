﻿using Capgemini.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capgemini.Services
{
    public static class BillService
    {
        public static Bill ProduceBill(List<Item> purchasedItems)
        {
            var totalPrice = purchasedItems.Sum(x => x.Price);

            var bill = new Bill { Total = totalPrice };

            if (purchasedItems.All(x => x.Type == ItemType.Drink))
                return bill;

            var serviceCharge = Math.Round(bill.Total * .10m, 2);

            bill.Total += serviceCharge;

            return bill;
        }
    }
}
