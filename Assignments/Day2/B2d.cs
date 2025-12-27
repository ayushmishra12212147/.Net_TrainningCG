using System;

public class B2d
{
    public static void bMain()
    {
        System.Console.WriteLine("Enter Binary Number");
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
        int l=0;
        double dec=0.0;
        while (number1 > 0)
        {
            dec=dec+number1%10*Math.Pow(2,l);
            l++;
            number1=number1/10; 
        }
        System.Console.WriteLine("The Decimal Value is {0}",dec);





    }
}