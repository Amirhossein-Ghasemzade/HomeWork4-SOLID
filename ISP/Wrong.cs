using System;
using System.Collections.Generic;
using System.Text;

namespace ISPExample
{
    public interface IMachine
    {
        void Print();
        void Scan();
    }

    public class OldPrinter : IMachine
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            // این متد اصلا به درد این کلاس نمیخوره
            throw new NotImplementedException();
        }
    }
}
