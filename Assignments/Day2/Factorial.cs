using System;
class Factorial
{
    public static void FactMain()
    {
        System.Console.WriteLine("=======================");
        System.Console.WriteLine("Factorial Checking System");
        System.Console.WriteLine("Enter Number to check Factorial");
        string? input=Console.ReadLine();
        if(!int.TryParse(input,out int number))
        {
            System.Console.WriteLine("Input number is integer");
            return;
        }
        System.Console.WriteLine("Factorial is {0}",Fact(number)); 
        
    }
    public static int Fact(int n)
    {
        if(n==1 || n == 0)
        {
            return 1;
        }
        else
        {
            return n*Fact(n-1);
        }
        
    }
}