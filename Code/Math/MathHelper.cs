﻿using System;
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
    }
}