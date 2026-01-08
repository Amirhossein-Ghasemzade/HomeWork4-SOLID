using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    public class FixedDiscounts : IDiscount
    {
        private decimal amount;

        public FixedDiscounts(decimal amount)
        {
            this.amount = amount;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - amount;
        }
    }
}
