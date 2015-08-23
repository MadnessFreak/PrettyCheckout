using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrettyCheckout.Dialogs.Controls
{
    public class NumericTextBox : TextBox
    {
        bool allowSpace = false;
        bool allowNegativeSign = false;
        bool allowGroupSeparator = false;

        // Restricts the entry of characters to digits (including hex), the negative sign, 
        // the decimal point, and editing keystrokes (backspace). 
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;

            // Workaround for groupSeparator equal to non-breaking space 
            if (groupSeparator == ((char)160).ToString())
            {
                groupSeparator = " ";
            }

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (keyInput.Equals(decimalSeparator) || (keyInput.Equals(groupSeparator) && allowGroupSeparator) || (keyInput.Equals(negativeSign) && allowNegativeSign))
            {
                // Decimal separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            //    else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0) 
            //    { 
            //     // Let the edit control handle control and alt key combinations 
            //    } 
            else if (this.allowSpace && e.KeyChar == ' ')
            {

            }
            else
            {
                // Consume this invalid key and beep
                e.Handled = true;
                //    MessageBeep();
            }
        }

        public int IntValue
        {
            get
            {
                Int32 int32;
                Int32.TryParse(this.Text, out int32);

                return int32;
            }
        }

        public decimal DecimalValue
        {
            get
            {
                Decimal dec;
                Decimal.TryParse(this.Text, out dec);

                return dec;
            }
        }

        public bool AllowSpace
        {
            set
            {
                this.allowSpace = value;
            }

            get
            {
                return this.allowSpace;
            }
        }

        public bool AllowNegativeSign
        {
            set
            {
                this.allowNegativeSign = value;
            }

            get
            {
                return this.allowNegativeSign;
            }
        }

        public bool AllowGroupSeparator
        {
            set
            {
                this.allowGroupSeparator = value;
            }

            get
            {
                return this.allowGroupSeparator;
            }
        }
    }
}
