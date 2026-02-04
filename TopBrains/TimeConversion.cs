using System;
namespace TopBrains
{
    public class TimeConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Time in seconds");
            int input=Convert.ToInt32(Console.ReadLine());
            int min=input/60;
            int sec=input%60;
            if (sec > 9)
            {
                Console.WriteLine($"{min}:{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:0{sec}");
                
            }
        }
    }
}