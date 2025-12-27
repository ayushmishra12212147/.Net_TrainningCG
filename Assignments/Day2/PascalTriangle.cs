using System;
public class PascalTriangle
{
    public static void pascalMain()
    {
        System.Console.WriteLine("Enter N for number of rows for pascal triangle");
        String? input = Console.ReadLine();
        if (!int.TryParse(input, out int n))
        {
            System.Console.WriteLine("Not a Valid number");
            return;
        }
        if (n <= 0)
        {
            System.Console.WriteLine("Number Entered is negative");
            return;
        }
        int pre;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n-i-1;j++)
            {
                System.Console.Write(" ");
            }
            pre=1;
            for(int j = 0; j <i+1; j++)
            {
                System.Console.Write(pre+" ");
                pre=pre* (i - j) / (j + 1);
            }
            System.Console.WriteLine("");
        }
    }
}