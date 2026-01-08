using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.FalseExample
{
    public class MembershipFeeCalculator
    {
        public double CalculateFee(string memberType)
        {
            if (memberType == "Student")
            {
                return 5;
            }
            else if (memberType == "Teacher")
            {
                return 10;
            }
            else
            {
                return 15;
            }
        }
    }
}
