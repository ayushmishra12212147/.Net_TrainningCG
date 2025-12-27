using System;
public class Diamond
{
    public static void diamondMain()
    {
        System.Console.WriteLine("Enter Number");
        String? input = Console.ReadLine();
        if (!int.TryParse(input, out int number1))
        {
            System.Console.WriteLine("Not a Valid number");
            return;
        }
        if (number1 < 0)
        {
            System.Console.WriteLine("Number Entered is negative");
            return;
        }

        for(int i = 0; i < number1; i++)
        {
            for(int j = 0; j < number1 - i - 1; j++)
            {
                System.Console.Write(" ");
            }
            for(int j = 0; j < i + 1; j++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine(" ");
        }
        
        for(int i = 0; i < number1; i++)
        {
            for(int j = 0; j < i; j++)
            {
                System.Console.Write(" ");
            }
            for(int j = number1; j > i; j--)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine("");
        }
    }
}