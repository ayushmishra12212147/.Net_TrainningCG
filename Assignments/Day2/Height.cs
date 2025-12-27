using System;
public class Height
{
    public static void heightMain()
    {
        System.Console.WriteLine("Enter Your height...");
        String? input = Console.ReadLine();
        if (!int.TryParse(input, out int height))
        {
            System.Console.WriteLine("Not a Valid number");
            return;
        }
        if (height <= 0)
        {
            System.Console.WriteLine("Number Entered is negative");
            return;
        }
        else
        {
            if (height < 150)
            {
                System.Console.WriteLine("Dwarf");
                return;
            }
            else if (height < 165)
            {
                System.Console.WriteLine("Average");
            }
            else if (height < 190)
            {
                System.Console.WriteLine("Tall");
            }
            else
            {
                System.Console.WriteLine("Abnormal");
            }
        }

    }
}