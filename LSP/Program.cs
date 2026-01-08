using LSPExample;
using System;

// کلاس فرزند باید بتواند جای کلاس والد را بگیرد بدون اینکه به مشکلی بخورد 

namespace LSPExample
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseClass objFalse = new FalseChild();
            Console.WriteLine("FalseChild (false LSP): " + objFalse.GetValue()); // خروجی: false

            BaseClass objTrue = new TrueChild();
            Console.WriteLine("TrueChild (true LSP): " + objTrue.GetValue()); // خروجی: true
        }
    }
}
