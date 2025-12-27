using System;
namespace Day2DemoConsole
{
    public class Guess
    {
        public static void guessMain()
        {
            int randomNumber=Random.Shared.Next(100);

            

            do{
                System.Console.WriteLine("Enter a number between 1 to 10");
            string? input=Console.ReadLine();

            if(!int.TryParse(input,out int userChoice))
            {
                System.Console.WriteLine("Wrong Input");
                return;
            }
                if (userChoice >randomNumber)
                {
                    System.Console.WriteLine("Your Choice is larger than the guess Number");
                    
                }else if (userChoice < randomNumber)
                {
                    System.Console.WriteLine("Think of a Higher Number.......");
                }
                else
                {
                    System.Console.WriteLine("Correct Choice {0}",randomNumber);
                    break;
                }
                
            }while(true);
        }
    }
}