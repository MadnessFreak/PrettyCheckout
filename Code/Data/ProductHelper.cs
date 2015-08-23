using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrettyCheckout.Data
{
    public static class ProductHelper
    {
        public const string DecimalFormat = "0.00 €";

        public static ListViewItem.ListViewSubItem At(this ListViewItem.ListViewSubItemCollection collection, ProductListViewOrder order)
        {
            return collection[(int)order];
        }

        public static bool ContainsProduct(this ListView.ListViewItemCollection collection, string productListViewKey)
        {
            foreach (ListViewItem item in collection)
            {
                if (item.Text == productListViewKey) return true;
            }

            return false;
        }

        public static bool IndexOfProduct(this ListView.ListViewItemCollection collection, string productListViewKey)
        {
            foreach (ListViewItem item in collection)
            {
                if (item.Text == productListViewKey) return true;
            }

            return false;
        }
    }
}
