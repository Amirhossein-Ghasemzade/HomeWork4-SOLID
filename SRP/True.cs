using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.TrueExample
{
    public class BookService
    {
        public void AddBook(string bookName)
        {
            System.Console.WriteLine("Book added: " + bookName);
        }
    }

    public class BorrowService
    {
        public void BorrowBook(string bookName, string memberName)
        {
            System.Console.WriteLine(memberName + " borrowed " + bookName);
        }
    }

    public class NotificationService
    {
        public void SendNotification(string memberName)
        {
            System.Console.WriteLine("Notification sent to " + memberName);
        }
    }
}
