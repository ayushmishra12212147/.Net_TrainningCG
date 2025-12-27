using System;
public class Largest
{
    public static void LargestMain()
    {
        System.Console.WriteLine("Enter 1st number here...");
        string? input1 = Console.ReadLine();
        if (!int.TryParse(input1, out int number1))
        {
            System.Console.WriteLine("The Input is not a number");
            return;
        }
        System.Console.WriteLine("Enter 2nd number here...");
        string? input2 = Console.ReadLine();
        if (!int.TryParse(input2, out int number2))
        {
            System.Console.WriteLine("The Input is not a number");
            return;
        }
        System.Console.WriteLine("Enter 3rd number here...");
        string? input3 = Console.ReadLine();
        if (!int.TryParse(input3, out int number3))
        {
            System.Console.WriteLine("The Input is not a number");
            return;
        }
        int result;
        if (number1 > number2)
        {
            if (number1 > number3)
            {
                result = number1;
            }
            else
            {
                result = number3;
            }
        }
        else
        {
            if (number2 > number3)
            {
                result = number2;
            }
            else
            {
                result = number3;
            }
        }

        System.Console.WriteLine("largest Number {0}", result);
    }
}