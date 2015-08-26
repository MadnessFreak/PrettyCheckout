using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;

using PrettyCheckout;
using PrettyCheckout.Data;
using PrettyCheckout.Dialogs;
using PrettyCheckout.Math;

namespace PrettyCheckout.Data
{
    public class BillingHistory
    {
        // Properties
        public List<Bill> Bills { get; private set; }

        // Constants
        public const string BillingHistoryFileVersion = "1.0";
        public const string BillingHistoryPath = "BillingHistory.xml";

        // Constructor
        public BillingHistory()
        {
            Bills = new List<Bill>();
        }

        // Methods
        public void Load(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                //MessageBox.Show("Billing history file not found - " + path);
                return;
            }

            var document = XDocument.Load(path);

            if (document.Root.Attribute("Version").Value != BillingHistoryFileVersion)
            {
                MessageBox.Show("Billing history file version is invalid - " + path);
                return;
            }

            Bills.Clear();

            foreach (XElement element in document.Root.Descendants())
            {
                if (element.Name == "Bill")
                {
                    var bill = new Bill
                    (
                         DateTime.Parse(element.Attribute("Date").Value)
                    )
                    {
                        Total = element.Attribute("Total").Value.AsMoney()
                    };

                    var products = element.Element("Products");
                    foreach (var sub in products.Elements())
                    {
                        var product = new Product
                        (
                            sub.Attribute("ID").Value.AsInteger(),
                            sub.Attribute("Name").Value,
                            sub.Attribute("Price").Value.AsDecimal()
                        );

                        bill.AddProduct(product, sub.Attribute("Amount").Value.AsInteger());
                    }

                    Bills.Add(bill);
                }
            }
        }

        public void Save(string path)
        {
            var document = new XDocument();
            var root = new XElement("BillingHistory", new XAttribute("Version", BillingHistoryFileVersion));

            foreach (var bill in Bills)
            {
                var element = new XElement("Bill");
                element.Add(new XAttribute("Date", bill.Date));
                element.Add(new XAttribute("Total", bill.Total));

                var products = new XElement("Products");
                foreach (var billProduct in bill.Products)
                {
                    var product = new XElement("Product");
                    product.Add(new XAttribute("ID", billProduct.Index));
                    product.Add(new XAttribute("Name", billProduct.Name));
                    product.Add(new XAttribute("Price", billProduct.Price));
                    product.Add(new XAttribute("Total", billProduct.Price * billProduct.Amount));
                    product.Add(new XAttribute("Amount", billProduct.Amount));

                    products.Add(product);
                }

                element.Add(products);
                root.Add(element);
            }
            
            document.Add(root);

            try
            {
                document.Save(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Billing history file could not be saved - " + path);
            }
        }
    }
}
