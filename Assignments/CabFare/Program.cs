using System;
namespace CabFare
{
    public class Program
    {
        public static void Main()
        {
            CabDetails cab = null;
            System.Console.WriteLine("==================");
            System.Console.WriteLine("Welcome to Cab Fare Calculation System");
            System.Console.WriteLine("Enter Booking Id to start");
            string? bookingId1 = Console.ReadLine();
            cab=new CabDetails();
            cab.bookingID = bookingId1;
            
            if (!cab.validateBookingId())
            {
                System.Console.WriteLine("Invaid Booking Id");

            }
            else
            {
                System.Console.WriteLine("Enter Cab Type");
                string? cabType = Console.ReadLine();

                System.Console.WriteLine("Enter distance in Km");
                int distance = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("Enter waiting time in Mins");
                int waitingTime = Convert.ToInt32(Console.ReadLine());

                cab.cabType = cabType;
                cab.distance = distance;
                cab.waitingTime = waitingTime;
                System.Console.WriteLine("Fare is Rs.{0}", cab.CalculateFareAmount());

            }
        }
    }
}