using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.FalseExample
{
    public class False
    {
        public void AddBook(string bookName)
        {
            System.Console.WriteLine("Book added: " + bookName);
        }

        public void BorrowBook(string bookName, string memberName)
        {
            System.Console.WriteLine(memberName + " borrowed " + bookName);
        }

        public void SendNotification(string memberName)
        {
            System.Console.WriteLine("Notification sent to " + memberName);
        }
    }
}
