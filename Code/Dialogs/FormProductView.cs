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
        public decimal SelectedVat { get; set; }

        // Constructor
        public FormProductView()
        {
            InitializeComponent();
        }

        public FormProductView(Product product)
        {
            InitializeComponent();
            Product = product;

            if (Config.Get<bool>("billing.vat.enable"))
            {
                _radioButtonVat19.Select();
            }
            else
            {
                _radioButtonVatZero.Select();
                _radioButtonVatZero.Enabled = false;
                _radioButtonVat7.Enabled = false;
                _radioButtonVat19.Enabled = false;
                _textBoxPriceNet.Enabled = false;
            }
        }

        // Methods
        private void FormProductView_Load(object sender, EventArgs e)
        {
            if (Product != null)
            {
                _textBoxID.Text = Product.Index.ToString();
                _textBoxName.Text = Product.Name;
                _textBoxPriceGross.Text = Product.Price.ToString(ProductHelper.DecimalFormat);
                _textBoxDesc.Text = Product.Description;
            }

            if (_textBoxID.TextLength < 1)
            {
                var max = Program.Environment.Products.Count < 1 ? 0 : Program.Environment.MaxBy(p => p.Index).Index;
                _textBoxID.Text = (max + 1).ToString();
            }

            _textBoxName.Select();
        }

        private void ButtonAcceptClick(object sender, EventArgs e)
        {
            if (_buttonAccept.Tag == null)
            {
                CaluclateVat();

                _buttonAccept.Text = "OK";
                _buttonAccept.Tag = 1;
            }
            else
            {
                var index = _textBoxID.IntValue;
                var name = _textBoxName.Text;
                var price = _textBoxPriceGross.MoneyValue;
                var net = _textBoxPriceNet.MoneyValue;
                var desc = _textBoxDesc.Text;

                if (index < 0)
                {
                    MessageBox.Show("Ungültige Produkt-ID");
                    return;
                }
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Ungültiger Name");
                    return;
                }
                if (price < 0.00m)
                {
                    MessageBox.Show("Ungültiger Preis");
                    return;
                }

                if (Product == null)
                {
                    Product = new Product(index, name, price);
                }
                else
                {
                    Product.Name = name;
                    Product.Price = price;
                    Product.PriceN = net;
                    Product.Description = desc;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void RadioButtonVatCheckedChanged(object sender, EventArgs e)
        {
            var control = sender as Control;
            if (control == null) return;

            switch (control.Tag.ToString())
            {
                case "0": SelectedVat = 0; break;
                case "1": SelectedVat = 7; break;
                case "2": SelectedVat = 19; break;
                default: SelectedVat = 0; break;
            }

            CaluclateVat();
        }

        private void TextBoxPriceGrossTextChanged(object sender, EventArgs e)
        {
            CaluclateVat();
        }

        private void TextBoxPriceNetTextChanged(object sender, EventArgs e)
        {
            //_textBoxPriceGross.Text = MathHelper.GrossToNet(_textBoxPriceNet.DecimalValue, SelectedVat).ToString(ProductHelper.DecimalFormat);
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void CaluclateVat()
        {
            _textBoxPriceNet.Text = MathHelper.NetToGross(_textBoxPriceGross.MoneyValue, SelectedVat).ToString(ProductHelper.DecimalFormat);
            _textBoxVat.Text = (_textBoxPriceGross.MoneyValue - _textBoxPriceNet.MoneyValue).ToString(ProductHelper.DecimalFormat);
        }
    }
}
