using System;
public class DateCheck
{
    public static void datecheckMain()
    {
        System.Console.WriteLine("Enter Date");
        string? input1=Console.ReadLine();
        if(!int.TryParse(input1,out int date))
        {
            System.Console.WriteLine("Input was incorrect");
            return;
        }
        if (date <= 0)
        {
            System.Console.WriteLine("It cannot be negative or zero");
            return;
        }

        System.Console.WriteLine("Enter Month");
        string? input2=Console.ReadLine();
        if(!int.TryParse(input2,out int month))
        {
            System.Console.WriteLine("Input was incorrect");
            return;
        }
        if (month <= 0)
        {
            System.Console.WriteLine("It cannot be negative or zero");
            return;
        }

        System.Console.WriteLine("Enter year");
        string? input3=Console.ReadLine();
        if(!int.TryParse(input3,out int year))
        {
            System.Console.WriteLine("Input was incorrect");
            return;
        }
        if (year <= 0)
        {
            System.Console.WriteLine("It cannot be negative or zero");
            return;
        }


        switch (month)
        {
            case 1:
                {
                    if (date > 31)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            
            case 2:
                {
                    if((year%4==0 && year%100!=0)|| year % 400 == 0)
                    {
                        if (date > 29)
                        {
                            System.Console.WriteLine("Invalid Date");
                            return;
                        }
                    }
                    else
                    {
                        if (date > 28)
                        {
                            System.Console.WriteLine("Invalid Date");
                            return;
                        }
                    }
                    break;
                }
            case 3:
                {
                    if (date > 31)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 4:
                {
                    if (date > 30)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 5:
                {
                    if (date > 31)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 6:
                {
                    if (date > 30)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 7:
                {
                    if (date > 31)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 8:
                {
                    if (date > 31)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 9:
                {
                    if (date > 30)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 10:
                {
                    if (date > 31)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 11:
                {
                    if (date > 30)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            case 12:
                {
                    if (date > 31)
                    {
                        System.Console.WriteLine("invalid Date");
                        return;
                    }
                    break;
                }
            
            
        }

        System.Console.WriteLine("Valid Date");

    }
}