using OnlineShop;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            IDiscount discount = new PercentageDiscount(10);
            IEmailService emailService = new EmailService();

            OrderService order = new OrderService(discount, emailService);
            order.Buy(100);
        }
    }
}
