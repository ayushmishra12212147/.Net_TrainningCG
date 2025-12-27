using System;
public class Roots
{
    public static void rootMain()
    {
        System.Console.WriteLine("Enter for x^2");
        String? input1=Console.ReadLine();
        if (!int.TryParse(input1,out int a))
        {
            System.Console.WriteLine("Your Input is not a number");
            return;
        }
        if (a == 0)
        {
            System.Console.WriteLine("This is a invalid input, value of coefficient of x^2 cannot be 0");
            return;
        }
        System.Console.WriteLine("Enter for x");
        String? input2=Console.ReadLine();
        if (!int.TryParse(input2,out int b))
        {
            System.Console.WriteLine("Your Input is not a number");
            return;
        }
        System.Console.WriteLine("Enter for constant");
        String? input3=Console.ReadLine();
        if (!int.TryParse(input3,out int c))
        {
            System.Console.WriteLine("Your Input is not a number");
            return;
        }
        double d=Convert.ToDouble(b*b - 4*a*c);
        double root1,root2;
        if (d == 0)
        {
            root1=-b/(2*a);
            System.Console.WriteLine("It has only 1 root: {0}",root1);
        }
        else if (d > 0)
        {
            root1= (-b+Math.Sqrt(d))/2*a;
            root2= (-b-Math.Sqrt(d))/2*a;
            System.Console.WriteLine("It has 2 roots: {0} and {1}",root1,root2);
        }
        else
        {
            System.Console.WriteLine("Complex roots as value of B^2 -4a*c is negative");
        }
    }
}