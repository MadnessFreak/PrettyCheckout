using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyCheckout.Math
{
    public static class MathHelper
    {
        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static bool IsNumeric(this string text)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(text), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static int AsInteger(this string text)
        {
            Int32 int32;
            Int32.TryParse(text, out int32);

            return int32;
        }

        public static decimal AsDecimal(this string text)
        {
            text = text.Replace("€", "").Trim();

            Decimal dec;
            Decimal.TryParse(text, out dec);

            return dec;
        }
    }
}
