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
    public partial class FormSearch : Form
    {
        public Product SelectedProduct
        {
            get { return _listView.SelectedItems.Count == 1 ? Program.Environment.GetProduct(_listView.SelectedItems[0].Name.AsInteger()) : null; }
        }

        public FormSearch()
        {
            InitializeComponent();
        }        

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void _textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (_textBoxSearch.TextLength < 3) return;

            var search = _textBoxSearch.Text.ToLower();
            var products = Program.Environment.Products.FindAll(
                p => p.Index.ToString() == search || 
                p.Name.ToLower().Contains(search) ||
                p.Description.ToLower().Contains(search)
            );

            _listView.Items.Clear();
            foreach (var product in products)
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

        private void _listView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SelectedProduct != null)
            {
                if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void _buttonSearch_Click(object sender, EventArgs e)
        {
           _textBoxSearch_TextChanged(this, EventArgs.Empty);
        }

        private void _listView_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedProduct != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
