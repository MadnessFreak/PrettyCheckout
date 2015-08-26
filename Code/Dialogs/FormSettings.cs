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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (Config.EntryCount > 0)
            {
                _textBoxCompany.Text = Config.Get("cdata.company");
                _textBoxStreet.Text = Config.Get("cdata.street");
                _textBoxCity.Text = Config.Get("cdata.city");

                _textBoxDatabase.Text = Config.Get("database.path");

                _checkBoxVat.Checked = Config.Get<bool>("billing.vat.enable");
            }
        }

        private void ButtonAcceptClick(object sender, EventArgs e)
        {
            if (_textBoxCompany.TextLength < 1 ||
                _textBoxStreet.TextLength < 1 ||
                _textBoxCity.TextLength < 1 ||
                _textBoxDatabase.TextLength < 1)
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
                return;
            }

            Config.Set("cdata.company", _textBoxCompany.Text);
            Config.Set("cdata.street", _textBoxStreet.Text);
            Config.Set("cdata.city", _textBoxCity.Text);

            Config.Set("database.path", _textBoxDatabase.Text);

            Config.Set("billing.vat.enable", _checkBoxVat.Checked);

            Config.Save(Config.ConfigPath);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
