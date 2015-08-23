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
    public partial class FormProductView : Form
    {
        // Properties
        public Product Product { get; private set; }

        // Constructor
        public FormProductView()
        {
            InitializeComponent();
        }

        public FormProductView(Product product)
        {
            InitializeComponent();
            Product = product;
        }

        // Methods
        private void FormProductView_Load(object sender, EventArgs e)
        {
            if (Product != null)
            {
                _textBoxID.Text = Product.Index.ToString();
                _textBoxName.Text = Product.Name;
                _textBoxPrice.Text = Product.Price.ToString(ProductHelper.DecimalFormat);
                _textBoxDesc.Text = Product.Description;
            }

            _textBoxName.Select();
        }

        private void _buttonAccept_Click(object sender, EventArgs e)
        {
            var name = _textBoxName.Text;
            var price = _textBoxPrice.Text.AsDecimal();
            var desc = _textBoxDesc.Text;

            if (Product == null)
            {
                Product = new Product(5, name, price);
            }
            else
            {
                Product.Name = name;
                Product.Price = price;
                Product.Description = desc;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
