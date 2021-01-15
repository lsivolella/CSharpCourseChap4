using System;
using System.Collections.Generic;
using System.Text;

namespace Cap04
{
    class CurrencyConverter
    {
        public static double Iof = 0.06;
        public static double ReaisToBePaid(double dollarQuotation, double dollarAmount)
        {
            return dollarQuotation * (1 + Iof) * dollarAmount;
        }
    }
}
