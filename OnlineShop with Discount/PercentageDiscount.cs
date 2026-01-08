using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    public class PercentageDiscount : IDiscount
    {
        private int percent;

        public PercentageDiscount(int percent)
        {
            this.percent = percent;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - (price * percent / 100);
        }
    }
}
