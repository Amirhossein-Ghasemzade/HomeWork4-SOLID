
// اگر یک کلاس فقط به یک نوع عملکرد نیاز دارد، نباید مجبور باشد تمام متدهای یک interface بزرگ را پیاده‌سازی کند      

using ISPExample;
using System;
using System.Reflection;

namespace ISPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // استفاده از مثال درست
            IPrinter printer = new SimplePrinter();
            printer.Print();
        }
    }
}
