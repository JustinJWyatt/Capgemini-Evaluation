using System;
using System.Collections.Generic;
using System.Text;

namespace Capgemini.Models
{
    public class Item
    {
        private ItemType _itemType;

        public Item(string name, decimal price, ItemType itemType)
        {
            Name = name;
            Price = price;
            _itemType = itemType;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public ItemType Type
        {
            get
            {
                return _itemType;
            }

            set
            {
                _itemType = value;
            }
        }
    }
}
