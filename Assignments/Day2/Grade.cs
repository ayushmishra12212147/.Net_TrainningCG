using System;
public class Grade
{
    public static void gradeMain()
    {
        System.Console.WriteLine("Enter the Grade");
        string? input=Console.ReadLine();
        if(!char.TryParse(input,out char grade))
        {
            System.Console.WriteLine("Not a character");
            return;
        }
        grade=char.ToUpper(grade);
        switch (grade)
        {
            case 'E':
                {
                    System.Console.WriteLine("Excellent");
                    break;
                }
            case 'V':
                {
                    System.Console.WriteLine("Very Good");
                    break;
                }
            case 'G':
                {
                    System.Console.WriteLine("Good");
                    break;
                }
            case 'A':
                {
                    System.Console.WriteLine("Average");
                    break;
                }
            case 'F':
                {
                    System.Console.WriteLine("Fail");
                    break;
                }
            default:
                {
                    System.Console.WriteLine("Invalid input");
                    break;
                }
            
            
        }

    }
}