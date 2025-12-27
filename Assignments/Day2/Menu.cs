using System;
namespace Day2DemoConsole
{
    public class Menu
    {
        public static void menuMain()
        {
            do
            {
                System.Console.WriteLine("====================================");
                System.Console.WriteLine("Menu System");
                System.Console.WriteLine("1.Burger");
                System.Console.WriteLine("2.Noodles");
                System.Console.WriteLine("3.Pizza");
                System.Console.WriteLine("4.Exit");
                System.Console.WriteLine("Choose your Option..............");

                string? input=Console.ReadLine();
                if(!int.TryParse(input,out int userChoice))
                {
                    System.Console.WriteLine("Wrong Choice");
                    return;
                }
                switch (userChoice)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Burger Selected");
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Noodles Selected");
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Piza Selected");
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("Exit...........");

                            break;
                        }
                    

                }
                if (userChoice == 4)
                {
                    break;
                }
            }while(true);
            
        }
    }
}