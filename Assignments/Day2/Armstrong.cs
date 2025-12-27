using System;

public class Armstrong
{
    public static void armMain()
    {
        System.Console.WriteLine("Enter Number to check");
        string? input=Console.ReadLine();
        int length=input.Length;
        
        if(!int.TryParse(input,out int number))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }
        int numbercopy=number;
        double armvalue=0;

        while (number > 0)
        {
            armvalue+=Math.Pow(number%10,length);
            number=number/10;
        }
        if (armvalue == numbercopy)
        {
            System.Console.WriteLine("ArmStrong Number");
        }
        else
        {
            System.Console.WriteLine("Not An ArmStrong Number");
        }
        
    }
}