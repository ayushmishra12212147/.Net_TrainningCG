using System;
public class GcdLcm
{
    public static void GcdLcmMain()
    {
        System.Console.WriteLine("Enter 1st Number");
        String? input = Console.ReadLine();
        if (!int.TryParse(input, out int number1))
        {
            System.Console.WriteLine("Not a Valid number");
            return;
        }
        if (number1 <= 0)
        {
            System.Console.WriteLine("Number Entered is negative");
            return;
        }


        System.Console.WriteLine("Enter 1st Number");
        String? input2 = Console.ReadLine();
        if (!int.TryParse(input2, out int number2))
        {
            System.Console.WriteLine("Not a Valid number");
            return;
        }
        if (number2 <= 0)
        {
            System.Console.WriteLine("Number Entered is negative");
            return;
        }
        int lcm=LcmCalc(number1,number2);
        int gcd=GcdCalc(number1,number2);

        System.Console.WriteLine("The GCD is {0} and the LCM is {1}",gcd,lcm);
    }


    public static int LcmCalc(int num1,int num2)
    {
        int gcd=GcdCalc(num1,num2);

        return (num1*num2)/gcd;
        
    }

    public static int GcdCalc(int num1,int num2)
    {
        int small;
        if (num1 < num2)
        {
            small=num1;
            if (num2 % small == 0)
            {
                return small;
            }
            else
            {
                return GcdCalc(num2%small,small);
            }
        }
        else
        {
            small=num2;
            if (num1 % small == 0)
            {
                return small;
            }
            else
            {
                return GcdCalc(num1%small,small);
            }
        }
        
    }
}