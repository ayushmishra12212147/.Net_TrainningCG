using System;
public class Pallindrome
{
    public static void palMain()
    {
        System.Console.WriteLine("Enter Number to check Pallindrome");
        string? input=Console.ReadLine();
        if(!int.TryParse(input,out int number))
        {
            System.Console.WriteLine("Not a valid Number");
            return;
        }
        int numberCopy=number;
        int reverse=0;
        while (number > 0)
        {
            reverse=reverse*10+number%10;
            number=number/10;
        }
        if (reverse == numberCopy)
        {
            System.Console.WriteLine("Pallindrome Number");
        }
        else
        {
            System.Console.WriteLine("Not a Pallindrome Number");
        }

    }
}