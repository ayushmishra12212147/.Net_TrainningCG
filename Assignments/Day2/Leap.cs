using System;
public class Leap
{
    public static void leapMain()
    {
        System.Console.WriteLine("Enter Year to check if its a leap Year");
        string? input=Console.ReadLine();
        if(!int.TryParse(input,out int year))
        {
            System.Console.WriteLine("Wrong Input");
            return;
        }
        if (year < 0)
        {
            System.Console.WriteLine("Year Cannot be Negative");
        }
        else
        {
            if((year%4==0 && year%100!=0)|| year % 400 == 0)
            {
                System.Console.WriteLine("Yes, its a leap Year");
            }
            else
            {
                System.Console.WriteLine("Not a leap Year");
            }
        }
    }
}