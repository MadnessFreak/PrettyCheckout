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
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            _listView.Items.Clear();

            var index = 0;

            foreach (Bill bill in Program.BillingHistory.Bills.OrderByDescending(b => b.Date))
            {
                var date = bill.Date.ToString("MM.dd.yyyy HH:mm");
                var key = bill.Date.ToString() + index.ToString();

                var item = new ListViewItem(date)
                {
                    Name = key
                };
                item.SubItems.Add("Rechnung");
                item.SubItems.Add(bill.Products.Sum(p => (p.Price * p.Amount)).ToString(ProductHelper.DecimalFormat));

                _listView.Items.Add(item);
                index++;
            }
        }
    }
}
