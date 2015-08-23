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
    public partial class FormSubtotal : Form
    {
        // Properties
        public decimal Total { get; set; }
        public decimal Given { get; set; }
        public decimal ReturnMoney { get; set; }

        // Constructor
        public FormSubtotal()
            : this(0.00m)
        {
            InitializeComponent();
        }

        public FormSubtotal(decimal total)
        {
            InitializeComponent();
            Total = total;
        }

        // Methods
        private void FormSubtotal_Load(object sender, EventArgs e)
        {
            _textBoxTotalSum.Text = Total.ToString(ProductHelper.DecimalFormat);
            _textBoxGiven.Text = ProductHelper.DecimalFormat;
            _textBoxReturnMoney.Text = ProductHelper.DecimalFormat;

            _textBoxGiven.Select();
        }

        private void _buttonAccept_Click(object sender, EventArgs e)
        {
            if (_buttonAccept.Tag == null) // user data null?
            {
                Total = _textBoxTotalSum.Text.AsDecimal();
                Given = _textBoxGiven.Text.AsDecimal();

                ReturnMoney = Given - Total;

                _textBoxReturnMoney.Text = ReturnMoney.ToString(ProductHelper.DecimalFormat);
                _buttonAccept.Tag = 1; // set user data
                _buttonAccept.Text = "Fertig";
            }
            else
            {
                Finish();
            }
        }

        private void Finish()
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
