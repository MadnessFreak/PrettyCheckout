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
    public partial class FormMain : Form
    {
        // Variables
        private bool _orderCompleted;

        // Properties
        public ProductEnvironment Environment
        {
            get { return Program.Environment; }
        }
        public Decimal Sum { get; set; }

        // Constructor
        public FormMain()
        {
            InitializeComponent();
        }

        // Methods
        private void FormMain_Load(object sender, EventArgs e)
        {
            _textBoxProduct.Focus();
            
            Environment.Products.Add(new Product(1, "Wasser", 1.00m));
            Environment.Products.Add(new Product(2, "Saft", 1.50m));
            Environment.Products.Add(new Product(3, "Cola", 2.00m));
            Environment.Products.Add(new Product(4, "Bier", 1.50m));
        }

        private void ClearAll()
        {
            _textBoxTotalSum.Text = ProductHelper.DecimalFormat;
            _textBoxGiven.Text = ProductHelper.DecimalFormat;
            _textBoxReturnMoney.Text = ProductHelper.DecimalFormat;
            _textBoxReturnMoney.BackColor = Color.White;
            _textBoxAmount.Clear();
            _textBoxAmount.Text = "1";
            _listView.Items.Clear();
        }

        private void _textBoxProduct_TextChanged(object sender, EventArgs e)
        {
            var text = _textBoxProduct.Text;
            var green = Color.LightGreen;
            var red = Color.Salmon;

            if (_orderCompleted)
            {
                ClearAll();
                _orderCompleted = false;
            }

            if (text.IsNumeric()) // is numeric
            {
                if (Environment.HasProduct(text.AsInteger())) // is product
                {
                    _textBoxProduct.BackColor = green;
                }
                else
                {
                    _textBoxProduct.BackColor = red;
                }
            }
            else if (string.IsNullOrEmpty(text)) // is empty
            {
                _textBoxProduct.BackColor = Color.White;
            }
            else // is false
            {
                _textBoxProduct.BackColor = red;
            }
        }

        private void _textBoxProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;

            if (key == (char)Keys.C || key == 'c') // clear
            {
                _textBoxProduct.Clear();
                e.Handled = true;
            }
            else if (key == (char)Keys.X || key == (char)Keys.Multiply || key == '*' || key == 'x') // amount
            {
                _textBoxAmount.Focus();
                e.Handled = true;
            }
            else if (key == (char)Keys.Enter || key == (char)Keys.Return) // enter
            {
                _buttonNumEnter.PerformClick();
                e.Handled = true;
            }
        }

        private void _buttonNumEnter_Click(object sender, EventArgs e)
        {
            if (_textBoxProduct.TextLength > 0)
            {
                var index = _textBoxProduct.Text.AsInteger();
                if (Environment.HasProduct(index))
                {
                    var product = Environment.GetProduct(index);
                    var amount = _textBoxAmount.Text.AsInteger();

                    _textBoxProduct.Clear();
                    _textBoxAmount.Clear();
                    _textBoxAmount.Text = "1";

                    for (int i = 0; i < amount; i++)
                    {
                        Sum += product.Price;

                        InsertNewOrder(product);
                    }

                    _textBoxTotalSum.Text = Sum.ToString(ProductHelper.DecimalFormat);
                    _textBoxProduct.Select();
                }
                else
                {
                    MessageBox.Show("Unbekannte Produkt-ID!");
                }
            }
        }

        private void InsertNewOrder(Product product)
        {
            var item = new ListViewItem(product.ListViewKey) 
            { 
                Name = product.ListViewKey 
            };
            item.SubItems.Add(product.Name);
            item.SubItems.Add("1");
            item.SubItems.Add(product.Price.ToString(ProductHelper.DecimalFormat));
            item.SubItems.Add(product.Price.ToString(ProductHelper.DecimalFormat));

            if (_listView.Items.ContainsKey(product.ListViewKey))
            {
                var listViewItem = _listView.Items[product.ListViewKey];
                var amount = listViewItem.SubItems.At(ProductListViewOrder.Amount).Text.AsInteger();
                var price = listViewItem.SubItems.At(ProductListViewOrder.Price).Text.AsDecimal();

                amount++;

                listViewItem.SubItems.At(ProductListViewOrder.Amount).Text = amount.ToString();
                listViewItem.SubItems.At(ProductListViewOrder.Total).Text = (price * amount).ToString(ProductHelper.DecimalFormat);
            }
            else
            {
                _listView.Items.Add(item);
            }
        }

        private void _textBoxProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                var subtotal = new FormSubtotal(Sum);
                if (subtotal.ShowDialog() == DialogResult.OK)
                {
                    _textBoxReturnMoney.BackColor = Color.LightGreen;
                    _textBoxReturnMoney.Text = subtotal.ReturnMoney.ToString(ProductHelper.DecimalFormat);
                    _textBoxGiven.Text = subtotal.Given.ToString(ProductHelper.DecimalFormat);
                    _orderCompleted = true;
                }

                e.Handled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new FormProducts().Show();
        }
    }
}
