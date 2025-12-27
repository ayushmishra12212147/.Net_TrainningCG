using System;
using BooksManagment;
namespace BookManagment
{
    public class Progrm
    {
        public static void Main()
        {
            System.Console.WriteLine("=====================");
            System.Console.WriteLine("Welcome to BOOk Managment");
            Book book=null;
            System.Console.WriteLine("Enter the title");
            string title=Console.ReadLine();
            System.Console.WriteLine("Enter the Author");
            string author=Console.ReadLine();
            System.Console.WriteLine("Enter Number of Pages");
            int pages=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Date.");
            DateTime dueDate=DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Return Date");
            DateTime returnDate=Convert.ToDateTime(Console.ReadLine());
            System.Console.WriteLine("Enter The Days left");
            int daysLeft=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter daily Late feeRate");
            int feeRate=Convert.ToInt32(Console.ReadLine());




            book =new Book(title,author,pages,dueDate,returnDate,feeRate);

            System.Console.WriteLine("Average Pages Read per Day: {0}",book.AveragePageReadPerDay(daysLeft));

            System.Console.WriteLine("Late Fee: {0}",book.calculateLateFee());
        }
    }
}