using System;
using System.ComponentModel;
namespace Test2
{
    public class ExpenseTransaction : Transaction
    {
        /// <summary>
        /// Expense required a special property i.e. expensecategory so that the transaction expense category is known easily
        /// </summary>
        public string ExpenseCategory { get; set; }
        public override string getSummary()
        {
            return "Expense for "+ExpenseCategory+" is :"+Amount;
        }
    }
}