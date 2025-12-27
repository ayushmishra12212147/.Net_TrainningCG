using System;
public class Atm
{
    public static void atmMain()
    {
        int Savedpin = 1234;
        int balance = 10000;
        System.Console.WriteLine("Press 1 to insert ATM");
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out int atm))
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }
        if (atm == 1)
        {
            System.Console.WriteLine("Card Inserted Successfully\nPlease Enter Pin to initiate Transaction");
            string? input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int pin))
            {
                System.Console.WriteLine("Invalid Input");
                return;
            }
            if (pin == Savedpin)
            {
                System.Console.WriteLine("Please Enter Amount to withdraw");
                string? input3 = Console.ReadLine();
                if (!int.TryParse(input3, out int amount))
                {
                    System.Console.WriteLine("Invalid Input");
                    return;
                }
                if (balance >= amount)
                {
                    System.Console.WriteLine("Transaction Successfull - wait for cash");
                }
                else
                {
                    System.Console.WriteLine("Insufficient Amount in the account");
                }
            }
            else
            {
                System.Console.WriteLine("Incorrect Pin");
                return;
            }
        }
        else
        {
            System.Console.WriteLine("Invalid input");
        }
    }
}