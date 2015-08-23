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
    public class DataReader
    {
        // Properties

        // Constants
        public const string DataReaderFileVersion = "1.0";
        public const string DatabasePath = "PrettyCheckoutDatabase.xml";

        // Methods
        public static void Load(string path)
        {
            var document = XDocument.Load(path);

            if (document.Root.Attribute("Version").Value != DataReaderFileVersion)
            {
                MessageBox.Show("Data file version is invalid - " + path);
                return;
            }

            Program.Environment.Products.Clear();

            foreach (XElement element in document.Root.Descendants())
            {
                if (element.Name == "Product")
                {
                    var product = new Product
                    (
                        element.Attribute("ID").Value.AsInteger(),
                        element.Attribute("Name").Value,
                        element.Attribute("Price").Value.AsDecimal()
                    );
                    product.Description = element.Element("Description").Value;

                    Program.Environment.Products.Add(product);
                }
            }
        }

        public static void Save(string path)
        {
            var document = new XDocument();
            var root = new XElement("PrettyCheckoutDatabase", new XAttribute("Version", DataReaderFileVersion));

            foreach (var product in Program.Environment.Products)
            {
                var element = new XElement("Product");
                element.Add(new XAttribute("ID", product.Index));
                element.Add(new XAttribute("Name", product.Name));
                element.Add(new XAttribute("Price", product.Price));
                element.Add(new XElement("Description", new XCData(product.Description == null ? string.Empty : product.Description)));
                
                root.Add(element);
            }

            document.Add(root);

            try
            {
                document.Save(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Data file could not be saved - " + path);
            }
        }
    }
}
