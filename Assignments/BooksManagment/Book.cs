using System;
using System.Dynamic;

namespace BooksManagment
{

    public class Book
    {

        public string titile{set;get;}
        public string author{set;get;}
        public int numPages{set;get;}
        public DateTime dueDate{set;get;}
        public DateTime returnDate{set;get;}
        public int lateFee { get; }
        

        public Book()
        {
            titile="Dummy titile";
            author="Dummy Author";
            numPages=200;
            
            
        }
        public Book(string name,string author,int numPages,DateTime dueTime,DateTime returnDate,int lateFee)
        {
            this.titile=name;
            this.author=author;
            this.numPages=numPages;
            this.dueDate=dueTime;
            this.returnDate=returnDate;
            this.lateFee=lateFee;
            

        }


        public double AveragePageReadPerDay(int daysToRead)
        {

            return numPages/daysToRead;
        }

        public double calculateLateFee()
        {

            TimeSpan NumberOfDaysLeftToRead=returnDate-dueDate;
            int days=NumberOfDaysLeftToRead.Days;
            return days*lateFee;
        }

    }

}