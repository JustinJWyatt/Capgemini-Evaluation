using Capgemini.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capgemini.Web.Services
{
    public class BillService
    {
        public static Bill ProduceBill(List<Item> purchasedItems)
        {
            var totalPrice = purchasedItems.Sum(x => x.Price);

            var bill = new Bill { Total = totalPrice };

            if (purchasedItems.All(x => x.Type == ItemType.Drink))
                return bill;

            var serviceCharge = bill.Total * .10m;

            bill.Total += serviceCharge;

            return bill;
        }
    }
}
