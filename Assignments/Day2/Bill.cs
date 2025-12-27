using System;
public class Bill
{
    public static void billMain()
    {
        System.Console.WriteLine("Enter number of units to calculate bill");
        string? input=Console.ReadLine();
        if(!double.TryParse(input,out double units))
        {  
            System.Console.WriteLine("Invalid input");
            return;
        }
        double bill=0;
        if (units <= 199)
        {
            bill=units*1.2; 
        }else if(units <= 400)
        {
            bill=units*1.5;
        }else if(units <= 600)
        {
            bill=units*1.8; 
        }else
        {
            bill=units*2;
        }

        if (bill > 400)
        {
            bill=bill+0.15*bill;
        }

        System.Console.WriteLine("Your bill is {0}",bill);

    }
}