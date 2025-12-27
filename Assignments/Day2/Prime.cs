using System;
public class Prime
{
    public static void primeMain()
    {
        System.Console.WriteLine("Enter Number to Check Prime");
        string? input=Console.ReadLine();
        if(!int.TryParse(input,out int number))
        {
            System.Console.WriteLine("Invalid Input");
        }
        if (number == 1)
        {
            System.Console.WriteLine("The Number 1 can Neither be Prime Nor Composite");
            return;
        }
        if(number == 2 || number==3)
        {
            System.Console.WriteLine("Prime Number");
            return;
        }
        for(int i = 2; i <=Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                System.Console.WriteLine("Not Prime");
                return;
            }
        }
        System.Console.WriteLine("Prime Number");

    }
}