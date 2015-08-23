using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PrettyCheckout;
using PrettyCheckout.Data;
using PrettyCheckout.Dialogs;
using PrettyCheckout.Math;

namespace PrettyCheckout.Dialogs
{
    public partial class FormProducts : Form
    {
        // Properties
        public ProductEnvironment Environment
        {
            get { return Program.Environment; }
        }
        public Product SelectedProduct 
        {
            get { return _listView.SelectedItems.Count == 1 ? Environment.GetProduct(_listView.SelectedItems[0].Name.AsInteger()) : null; }
        }

        // Constructor
        public FormProducts()
        {
            InitializeComponent();
        }

        // Methods
        private void FormProducts_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            _listView.Items.Clear();

            foreach (var product in Environment.Products)
            {
                var item = new ListViewItem(product.ListViewKey)
                {
                    Name = product.ListViewKey
                };
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Price.ToString(ProductHelper.DecimalFormat));

                _listView.Items.Add(item);
            }
        }

        private void _listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listView.SelectedItems.Count == 1)
            {
                _buttonEdit.Enabled = true;
                _buttonDelete.Enabled = true;
            }
            else
            {
                _buttonEdit.Enabled = false;
                _buttonDelete.Enabled = false;
            }
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            ButtonProductChange();
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            ButtonProductChange(SelectedProduct);
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;

            if (MessageBox.Show("Willst du das Produkt \"" + SelectedProduct.Name + "\" wirklich löschen?", "Wirklich löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Products.Remove(SelectedProduct);
                Reload();
            }
        }

        private void ButtonProductChange()
        {
            ButtonProductChange(null);
        }

        private void ButtonProductChange(Product product)
        {
            var productView = new FormProductView(product);
            if (productView.ShowDialog() == DialogResult.OK)
            {
                if (!Environment.HasProduct(productView.Product.Index))
                {
                    Environment.Products.Add(productView.Product);
                }
                else
                {
                    Environment.Products[productView.Product.Index - 1] = productView.Product;
                }
                Reload();
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            DataReader.Save(DataReader.DatabasePath);
            Close();
        }
    }
}
