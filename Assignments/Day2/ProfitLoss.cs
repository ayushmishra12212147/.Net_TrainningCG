using System;
public class ProfitLoss
{
    public static void profitLossMain()
    {
        System.Console.WriteLine("Enter Cost Price");
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out int costPrice))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }


        System.Console.WriteLine("Enter Selling Price");
        string? input2 = Console.ReadLine();
        if (!int.TryParse(input2, out int sellingPrice))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }
        double result=0;
        if (sellingPrice > costPrice)
        {
            result=((sellingPrice-costPrice)/costPrice)*100;
            System.Console.WriteLine("Profit = {0}",result);
        }
        else
        {
            result=((costPrice-sellingPrice)/costPrice)*100;
            System.Console.WriteLine("Loss ={0}",result);
        }
    }
}