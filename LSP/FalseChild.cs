using System;
using System.Collections.Generic;
using System.Text;


namespace LSPExample
{
    public class BaseClass
    {
        public virtual bool GetValue()
        {
            return true; // انتظار برنامه همیشه true است
        }
    }

    public class FalseChild : BaseClass
    {
        public override bool GetValue()
        {
            return false; // رفتار غیرمنتظره
        }
    }
}
