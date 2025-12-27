using System;
using System.Collections;
namespace Test1
{
    public class Program
    {
        public static void Main()
        {
            ///There is only 1 program where i have given options to switch between both questions using switch Case

            System.Console.WriteLine("Which Program to Run");
            System.Console.WriteLine("1.Hospital Bill");
            System.Console.WriteLine("2.QuickMart");
            System.Console.WriteLine("Enter Your Choice");
            int questionChoice = Convert.ToInt32(Console.ReadLine());

            switch (questionChoice)
            {
                case 1:
                    {
                        PatientBill patient = null;
                        patient = new PatientBill();

                        System.Console.WriteLine("=================================");
                        do
                        {
                            System.Console.WriteLine("1.Create New Bill");
                            System.Console.WriteLine("2.View Last Bill");
                            System.Console.WriteLine("3.Clean LAst Bill");
                            System.Console.WriteLine("4.Exit");
                            System.Console.Write("Enter Your Option");
                            int userChoice = Convert.ToInt32(Console.ReadLine());

                            if (userChoice == 4)
                            {
                                break;
                            }


                            switch (userChoice)
                            {
                                case 1:
                                    {
                                        patient.createNewBill();

                                        break;
                                    }
                                case 2:
                                    {
                                        patient.ViewLastBill();
                                        break;
                                    }
                                case 3:
                                    {
                                        patient.ClearLastBill();
                                        break;
                                    }
                            }

                        } while (true);
                        break;
                    }
                case 2:
                    {
                        QuickMart quickMart=null;
                        quickMart=new QuickMart();


                        System.Console.WriteLine("=================================");
                        do
                        {
                            System.Console.WriteLine("1.Create New Transaction.");
                            System.Console.WriteLine("2.View Last Transaction");
                            System.Console.WriteLine("3.Calculate Profit or Loss");
                            System.Console.WriteLine("4.Exit");
                            System.Console.Write("Enter Your Option");
                            int userChoice = Convert.ToInt32(Console.ReadLine());

                            if (userChoice == 4)
                            {
                                break;
                            }


                            switch (userChoice)
                            {
                                case 1:
                                    {
                                        quickMart.createNewTransaction();

                                        break;
                                    }
                                case 2:
                                    {
                                        quickMart.viewLastTransaction();
                                        break;
                                    }
                                case 3:
                                    {
                                        quickMart.calculate();
                                        
                                        break;
                                    }
                            }

                        } while (true);

                        break;

                    }
            }



        }
    }
}