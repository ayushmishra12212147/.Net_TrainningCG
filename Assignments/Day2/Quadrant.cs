using System;
public class Quadrant
{
    public static void QuadrantMain()
    {
        System.Console.WriteLine("Enter the value of X");
        string? input1=Console.ReadLine();
        if(!int.TryParse(input1,out int X))
        {
            System.Console.WriteLine("Invalid input");
            return;
        }
        System.Console.WriteLine("Enter the value of Y");
        string? input2=Console.ReadLine();
        if(!int.TryParse(input2,out int Y))
        {
            System.Console.WriteLine("Invalid input");
        }

        if(X==0)
        {
            System.Console.WriteLine("The Point Lies on the Y-axis");
        }else if (Y == 0)
        {
            System.Console.WriteLine("The Point Lies on the X-axis");
        }
        else
        {
            if (X>0)
            {
                if (Y > 0)
                {
                    System.Console.WriteLine("The Point Lies in 1st Quadrant");
                }
                else
                {
                    System.Console.WriteLine("The Point Lies in 4th Quadrant");
                }

            }
            else
            {
                if (Y > 0)
                {
                    System.Console.WriteLine("The Point Lies in 2nd Quadrant");
                }
                else
                {
                    System.Console.WriteLine("The Point Lies in 3rd Quadrant");
                }
            }
        }
    }
    
}