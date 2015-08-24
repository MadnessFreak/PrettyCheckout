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
using System.Drawing.Printing;

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
            
            //Environment.Products.Add(new Product(1, "Wasser", 1.00m));
            //Environment.Products.Add(new Product(2, "Saft", 1.50m));
            //Environment.Products.Add(new Product(3, "Cola", 2.00m));
            //Environment.Products.Add(new Product(4, "Bier", 1.50m));
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
                var price = listViewItem.SubItems.At(ProductListViewOrder.Price).Text.AsMoney();

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

        private void _buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDocument PrintDoc = new PrintDocument();
            PrintDialog PrintDialog = new PrintDialog();
            PrintPreviewDialog PrintPreviewDialog = new PrintPreviewDialog();

            List<string> Printers = new List<string>();
            foreach (string p in PrinterSettings.InstalledPrinters)
            {
                Printers.Add(p);
            }

            // Alle verfügbaren Drucker sind in Printers gespeichert, man könnte den Benutzer daraus auswählen lassen.
            // In diesem Beispiel wird einfach immer Drucker 0 gewählt.
            PrintDoc.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters[0];

            PrintDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            //PrintDoc.Print();
            
            PrintDialog.Document = PrintDoc;
            //PrintDialog.ShowDialog();

            PrintPreviewDialog.Document = PrintDoc;
            PrintPreviewDialog.ShowDialog();
        }

        void PrintPage(object sender, PrintPageEventArgs e)
        {
            var font = new Font("Lucida Console", 10);
            var fontb = new Font("Lucida Console", 10, FontStyle.Bold);
            var brush = new SolidBrush(Color.Black);

            var buffer = new StringBuilder();
            buffer.Append(string.Format("{0}\n{1}\n{2}\n\n", "Musterfirma", "Musterstrasse 1", "12345 Musterstadt"));
            buffer.Append(string.Format("R E C H N U N G\nRechnungsnummer: {0}		  {1}\n\n", (1).ToString("000000"), DateTime.Now));
            buffer.Append("Menge\tProdukt\t\t\t\t Preis\t   Total\n");
            buffer.Append("-----------------------------------------------------\n");

            foreach (ListViewItem product in _listView.Items)
            {
                var name = product.SubItems.At(ProductListViewOrder.Name).Text;
                var price = product.SubItems.At(ProductListViewOrder.Price).Text.AsMoney();
                var total = product.SubItems.At(ProductListViewOrder.Total).Text.AsMoney();
                var amount = product.SubItems.At(ProductListViewOrder.Amount).Text.AsInteger();
                var format = "0.00€";

                buffer.Append(string.Format("{0}  {1} {2}  {3}\n", 
                    amount.ToString().PadLeft(5),
                    name.PadRight(31),
                    price.ToString(format).PadLeft(6),
                    total.ToString(format).PadLeft(6)
                ));
            }

            buffer.Append("-----------------------------------------------------\n");
            buffer.Append(string.Format("\t\t\t\tSumme:\t\t\t {0}\n", _textBoxTotalSum.Text.Replace(" ", "").PadLeft(7)));
            buffer.Append(string.Format("\t\t\t\tBargeld:\t\t {0}\n", _textBoxGiven.Text.Replace(" ", "").PadLeft(7)));
            buffer.Append(string.Format("\t\t\t\tZurück:\t\t {0}\n\n\n", _textBoxReturnMoney.Text.Replace(" ", "").PadLeft(7)));
            buffer.Append("\t\tVielen Dank für Ihren Besuch");

            e.Graphics.DrawLine(new Pen(Color.Black), new Point(0, 0), new Point(100, 100));
            e.Graphics.DrawString(buffer.ToString(), font, brush, new Point(100, 100));
        }
    }
}
