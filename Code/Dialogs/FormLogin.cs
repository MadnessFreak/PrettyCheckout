using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrettyCheckout.Dialogs
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
#if DEBUG
            _textBoxUser.Enabled = false;
            _textBoxUser.Text = "anonymous";
            _textBoxPassword.Focus();
            _textBoxPassword.Select();
#else
            _textBoxUser.Focus();
            _textBoxUser.Select();
#endif
        }

        private void ButtonAcceptClick(object sender, EventArgs e)
        {
            if (_textBoxUser.TextLength < 1 ||
                _textBoxPassword.TextLength < 1)
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
                return;
            }

#if DEBUG
            if (_textBoxUser.Text == "anonymous" &&
                _textBoxPassword.Text == "test123")
            {
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
#endif

            Close();
        }
    }
}
