using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    public class OrderService
    {
        private IDiscount discount;
        private IEmailService emailService;

        public OrderService(IDiscount discount, IEmailService emailService)
        {
            this.discount = discount;
            this.emailService = emailService;
        }

        public void Buy(decimal price)
        {
            decimal finalPrice = discount.ApplyDiscount(price);

            System.Console.WriteLine("Final Price: " + finalPrice);

            // ساخت فاکتور
            System.Console.WriteLine("Invoice Created");

            // ارسال ایمیل
            emailService.SendEmail();
        }
    }
}
