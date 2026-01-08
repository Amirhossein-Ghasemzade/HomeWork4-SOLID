using SRP.FalseExample;
using SRP.TrueExample;

// یعنی باید بتوانیم رفتار جدید اضافه کنیم بدون اینکه کد اصلی را تغییر دهیم. هدفش هم جلوگیری از خراب شدن کد موجود است.

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            MembershipFeeCalculator calculator = new MembershipFeeCalculator();
            System.Console.WriteLine("FalseExample (false OCP):");
            System.Console.WriteLine("Student fee: " + calculator.CalculateFee("Student"));
            System.Console.WriteLine("Teacher fee: " + calculator.CalculateFee("Teacher"));
            System.Console.WriteLine("Regular fee: " + calculator.CalculateFee("Regular"));

            System.Console.WriteLine("-------------------------");

            MembershipFeeProcessor processor = new MembershipFeeProcessor();

            IMembership student = new StudentMembership();
            IMembership teacher = new TeacherMembership();
            IMembership regular = new RegularMembership();

            System.Console.WriteLine("TrueExample (true OCP):");
            processor.PrintFee(student);
            processor.PrintFee(teacher);
            processor.PrintFee(regular);
        }
    }
}
