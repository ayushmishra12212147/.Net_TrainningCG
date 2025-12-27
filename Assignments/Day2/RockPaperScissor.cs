using System;
public class RockPaperScissor
{
    public static void RockPaperScissorMain()
    {
        System.Console.WriteLine("Player 1 Turn");
        System.Console.WriteLine("1. Rock");
        System.Console.WriteLine("2. Paper");
        System.Console.WriteLine("3. Scissor");
        System.Console.WriteLine("Enter your Choice");
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out int p1))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }


        System.Console.WriteLine("Player 2 Turn");
        System.Console.WriteLine("1. Rock");
        System.Console.WriteLine("2. Paper");
        System.Console.WriteLine("3. Scissor");
        System.Console.WriteLine("Enter your Choice");
        string? input1 = Console.ReadLine();
        if (!int.TryParse(input1, out int p2))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }

        if (p1 == p2)
        {
            System.Console.WriteLine("Draw.... try Again");
            return;
        }


        if(p1==1)
        {
            if (p2 == 2)
            {
                System.Console.WriteLine("Player 1 Wins");
            }
            else
            {
                System.Console.WriteLine("Player 2 Wins");
            }
        }else if (p1 == 2)
        {
            if (p2 == 1)
            {
                System.Console.WriteLine("Player 2 Wins");
            }
            else
            {
                System.Console.WriteLine("Player 1 Wins");
            }
        }
        else
        {
            if (p2 == 1)
            {
                System.Console.WriteLine("Player 2 Wins");
            }
            else
            {
                System.Console.WriteLine("Player 1 Wins");
            }
        }
    }
}