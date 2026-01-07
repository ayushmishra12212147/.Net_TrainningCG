using System;
using System.Collections.Generic;

namespace Test2
{
    class Program
    {
        static void Main()
        {
            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

            ///giving a default balance to user
            IncomeTransaction DefaultIncome=new IncomeTransaction();
                DefaultIncome.Id=0;
                DefaultIncome.Amount=500;
                DefaultIncome.dateTime=DateTime.Today;
                DefaultIncome.DiscriptionOfTransaction="Initial balance";
                DefaultIncome.source="Start Balance";

            
            incomeLedger.AddEntry(DefaultIncome);
            //Creating a do while to create a console app as menu driven for user

            do
            {
                System.Console.WriteLine("============================================");
                System.Console.WriteLine("=====Digital Petty Cash Le==================");
                System.Console.WriteLine("1. Add Income In Ledger.");
                System.Console.WriteLine("2. Add Expense in Ledger.");
                System.Console.WriteLine("3. List All Transactions.");
                System.Console.WriteLine("4. Display Totals");
                System.Console.WriteLine("5. Exit");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int flag = 0;
                






                switch (userInput)
                {

                    case 1:
                        {
                            IncomeTransaction income = new IncomeTransaction();
                            System.Console.WriteLine("Enter Income Id");
                            income.Id = Convert.ToInt32(Console.ReadLine());
                            income.dateTime = DateTime.Today;
                            System.Console.WriteLine("Enter Amount");
                            income.Amount = Convert.ToInt32(Console.ReadLine());
                            System.Console.WriteLine("Enter Income Discription");
                            income.DiscriptionOfTransaction = Console.ReadLine();
                            System.Console.WriteLine("Enter Income Source");
                            income.source = Console.ReadLine();

                            incomeLedger.AddEntry(income);


                            System.Console.WriteLine("Transaction Added Successsfully");


                            break;
                        }
                    case 2:
                        {

                            ExpenseTransaction expense = new ExpenseTransaction();
                            System.Console.WriteLine("Enter Expense Id");
                            expense.Id = Convert.ToInt32(Console.ReadLine());
                            expense.dateTime = DateTime.Today;
                            System.Console.WriteLine("Enter Amount");
                            expense.Amount = Convert.ToInt32(Console.ReadLine());
                            System.Console.WriteLine("Enter Income Discription");
                            expense.DiscriptionOfTransaction = Console.ReadLine();
                            System.Console.WriteLine("Enter Income Source");
                            expense.ExpenseCategory = Console.ReadLine();



                            expenseLedger.AddEntry(expense);
                            break;

                        }
                    case 3:
                        {

                            List<Transaction> allTransaction = new List<Transaction>();
                            allTransaction.AddRange(incomeLedger.getAll());
                            allTransaction.AddRange(expenseLedger.getAll());
                            foreach (Transaction trans in allTransaction)
                            {
                                System.Console.WriteLine(trans.getSummary());
                            }

                            break;

                        }
                    case 4:
                        {
                            System.Console.WriteLine("Summary Display Of Ledger");
                            double ExpenseTotal = expenseLedger.CalculateTotal();
                            double IncomeTotal = incomeLedger.CalculateTotal();
                            System.Console.WriteLine($"The Total Income is {IncomeTotal}");
                            System.Console.WriteLine($"The Total Expense is {ExpenseTotal}");
                            System.Console.WriteLine($"Net balance is {IncomeTotal - ExpenseTotal}");

                            break;
                        }
                    default:
                        {
                            flag = 1;
                            System.Console.WriteLine("System Exit initiated");
                            break;
                        }

                }
                if (flag == 1)
                {
                    break;
                }

            } while (true);

        }
    }

}
