using System;
public class Vowel
{
    public static void vowelMain()
    {
        System.Console.WriteLine("Enter your choice to check for vowel");
        string? input=Console.ReadLine();
        if(!char.TryParse(input,out char check))
        {
            System.Console.WriteLine("Input is not a character");
            return; 
        }
        switch(check){
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                {
                    System.Console.WriteLine("Its a Vowel");
                    break;
                }
            default:
                {
                    System.Console.WriteLine("Its a Consonant");
                    break;
                }
        }
    }
}