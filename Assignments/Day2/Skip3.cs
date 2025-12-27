using System;
namespace Day2DemoConsole
{
    public class Skip3
    {
        public static void skipMain()
        {
            System.Console.WriteLine("=======================");
            System.Console.WriteLine("Starting to Print numbers from 1 to 50 and skipping all numbers divisible by 3");
            for(int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                System.Console.WriteLine(i);
            }
        }
    }
}