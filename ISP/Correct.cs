using System;
using System.Collections.Generic;
using System.Text;

namespace ISPExample
{
    // اینترفیس مخصوص پرینت
    public interface IPrinter
    {
        void Print();
    }

    // اینترفیس مخصوص اسکن
    public interface IScanner
    {
        void Scan();
    }

    // این کلاس فقط پرینتره
    public class SimplePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}

