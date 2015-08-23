using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyCheckout.Data
{
    public class ProductEnvironment : IEnumerable, IEnumerable<Product>
    {
        // Properties
        public List<Product> Products { get; set; }

        // Constructor
        public ProductEnvironment()
        {
            Products = new List<Product>();
        }

        // Methods
        public bool HasProduct(int index)
        {
            return Products.Find(p => p.Index == index) == null ? false : true;
        }

        public bool HasProduct(string name)
        {
            return Products.Find(p => p.Name == name) == null ? false : true;
        }

        public Product GetProduct(int index)
        {
            return Products.Find(p => p.Index == index);
        }

        public Product GetProduct(string name)
        {
            return Products.Find(p => p.Name == name);
        }

        public IEnumerator GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator<Product> IEnumerable<Product>.GetEnumerator()
        {
            return Products.GetEnumerator();
        }
    }
}
