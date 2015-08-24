using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyCheckout.Data
{
    /// <summary>
    /// Provides properties for a bill.
    /// </summary>
    public class Bill
    {
        // Properties
        /// <summary>
        /// Gets a collection of all products of the bill.
        /// </summary>
        public List<BillEntry> Products { get; private set; }
        /// <summary>
        /// Gets or sets the date of the bill.
        /// </summary>
        public DateTime Date { get; set; }

        // Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="PrettyCheckout.Data.Bill"/> class.
        /// </summary>
        public Bill()
            : this(DateTime.Now)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrettyCheckout.Data.Bill"/> class.
        /// <param name="date">The date of the bill.</param>
        /// </summary>
        public Bill(DateTime date)
        {
            Products = new List<BillEntry>();
            Date = date;
        }

        // Methods
        public void AddProduct(Product product)
        {
            AddProduct(product, 1);
        }

        public void AddProduct(Product product, int count)
        {
            if (Products.Find(p => p.Index == product.Index) != null)
            {
                var temp = Products.Find(p => p.Index == product.Index);
                temp.Amount += count;
            }
            else
            {
                Products.Add(new BillEntry(product, count));
            }
        }

        public void AddProductRange(IEnumerable<Product> collection)
        {
            foreach (var product in collection)
            {
                AddProduct(product);
            }
        }
    }
}
