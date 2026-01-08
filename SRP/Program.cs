using SRP.FalseExample;
using SRP.TrueExample;

// 1.  کد قابل فهم‌تر شود
// 2.  نگه‌داری و توسعه آسان‌تر شود
// 3.  کاهش وابستگی (Coupling)

namespace SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            False falseexample = new False();
            falseexample.AddBook("Clean Code");
            falseexample.BorrowBook("Clean Code", "Amir");
            falseexample.SendNotification("Hessam");

            System.Console.WriteLine("------------------------------");

            BookService bookService = new BookService();
            BorrowService borrowService = new BorrowService();
            NotificationService notificationService = new NotificationService();

            bookService.AddBook("Clean Code");
            borrowService.BorrowBook("Clean Code", "Reza");
            notificationService.SendNotification("Pedram");
        }
    }
}
