using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.TrueExample
{
    // Interface برای عضویت
    public interface IMembership
    {
        double GetFee();
    }

    // کلاس‌های جدا برای هر نوع عضویت
    public class StudentMembership : IMembership
    {
        public double GetFee()
        {
            return 5;
        }
    }

    public class TeacherMembership : IMembership
    {
        public double GetFee()
        {
            return 10;
        }
    }

    public class RegularMembership : IMembership
    {
        public double GetFee()
        {
            return 15;
        }
    }

    // Processor که فقط با Interface کار می‌کند
    public class MembershipFeeProcessor
    {
        public void PrintFee(IMembership membership)
        {
            System.Console.WriteLine("Membership fee: " + membership.GetFee());
        }
    }
}
 