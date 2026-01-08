using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal price);
    }
}
