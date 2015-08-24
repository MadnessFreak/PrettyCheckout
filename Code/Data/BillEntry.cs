using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyCheckout.Data
{
    public class BillEntry
    {
        // Properties
        public int Index { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        // Constructor
        public BillEntry(Product product)
            : this(product, 1)
        {
        }

        public BillEntry(Product product, int count)
        {
            Index = product.Index;
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            Amount = count;
        }
    }
}
