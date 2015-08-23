using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrettyCheckout.Data
{
    public class Product
    {
        // Properties
        public int Index { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string ListViewKey 
        {
            get { return Index.ToString(); }
        }

        // Constructor
        public Product(int index, string name, decimal price)
        {
            Index = index;
            Name = name;
            Price = price;
        }

        // Methods
    }

    public enum ProductListViewOrder
    {
        Index = 0,
        Name = 1,
        Amount = 2,
        Price = 3,
        Total = 4
    }
}
