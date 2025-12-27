using System;
public class Fib
{
    public static void fibMain()
    {
        System.Console.WriteLine("Enter The value of N");
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out int n))
        {
            System.Console.WriteLine("Wrong Input");
        }
        for (int i = 0; i < n; i++)
        {
            int res = Calculate(i);
            System.Console.Write(res + " ");
        }

    }

    public static int Calculate(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1 || n==2)
        {
            return 1;
        }
        else
        {
            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}