using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PrettyCheckout;
using PrettyCheckout.Dialogs;
using PrettyCheckout.Math;

namespace PrettyCheckout.Dialogs
{
    public partial class FormMain : Form
    {
        // Properties
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
        }

        private void _textBoxProduct_TextChanged(object sender, EventArgs e)
        {
            var text = _textBoxProduct.Text;
            if (text.IsNumeric())
            {
                //if (text is proc)
                //{

                //}
                //else
                //{

                //}
                _textBoxProduct.BackColor = Color.LightGreen;
            }
            else if (string.IsNullOrEmpty(text))
            {
                _textBoxProduct.BackColor = Color.White;
            }
            else
            {
                _textBoxProduct.BackColor = Color.IndianRed;
            }
        }

        private void _textBoxProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;

            if (key == (char)Keys.C) // clear
            {
                _textBoxProduct.Clear();
                e.Handled = true;
            }
            else if (key == (char)Keys.X || key == (char)Keys.Multiply) // amount
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
            Sum += _textBoxProduct.DecimalValue;

            _textBoxProduct.Clear();
            _textBoxAmount.Clear();
            _textBoxTotalSum.Text = Sum.ToString("0.00");
        }
    }
}
