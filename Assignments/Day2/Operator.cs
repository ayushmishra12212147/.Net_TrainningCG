using System;
public class Operator
{
    public static void operatorMain()
    {
        System.Console.WriteLine("Enter number 1");
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out int number1))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }

        System.Console.WriteLine("Enter number 1");
        string? input2 = Console.ReadLine();
        if (!int.TryParse(input2, out int number2))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }


        System.Console.WriteLine("Enter number 1");
        string? input3 = Console.ReadLine();
        if (!char.TryParse(input3, out char op))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }

        switch (op)
        {
            case '+':
                {
                    System.Console.WriteLine("Sum will be {0}",number1+number2);
                    break;
                }
            case '-':
                {
                    System.Console.WriteLine("Difference will be {0}",Math.Abs(number1-number2));
                    break;
                }
            case '*':
                {
                    System.Console.WriteLine("Product will be {0}",number1*number2);
                    break;
                }
            case '/':
                {
                    if(number1!=0){
                    System.Console.WriteLine("Sum will be {0}",number1+number2);
                    }
                    else
                    {
                        System.Console.WriteLine("Cannot divide by 0");
                    }
                    break;
                }



        }



    }
}