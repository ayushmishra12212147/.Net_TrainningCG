using System;
public class Triangle
{
    public static void triangleMain()
    {
        System.Console.WriteLine("Enter 1st side of Triangle ");
        string? input1=Console.ReadLine();
        if(!int.TryParse(input1,out int side1))
        {
            System.Console.WriteLine("Invalid input it should be an integer");
            return;
        }

        System.Console.WriteLine("Enter 2nd side of Triangle ");
        string? input2=Console.ReadLine();
        if(!int.TryParse(input2,out int side2))
        {
            System.Console.WriteLine("Invalid input it should be an integer");
            return;
        }

        System.Console.WriteLine("Enter 3rd side of Triangle ");
        string? input3=Console.ReadLine();
        if(!int.TryParse(input3,out int side3))
        {
            System.Console.WriteLine("Invalid input it should be an integer");
            return;
        }


        if(side1==side2 && side2 == side3)
        {
            System.Console.WriteLine("Equilateral Triangle");
        }
        else if(side1==side2 || side2==side3 || side3 == side1)
        {
            System.Console.WriteLine("Isosceles Triangle");
        }
        else
        {
            System.Console.WriteLine("Scalene Triangle");
        }
    }
}