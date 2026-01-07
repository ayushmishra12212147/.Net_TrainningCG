using System;
namespace Test2
{
    public class IncomeTransaction : Transaction
    {
        /// <summary>
        /// income transaction requires special property i.e. source where source of the amount is mentioned here 
        /// </summary>
        public string source { get; set; }

        /// <summary>
        /// The Summary of each income can be displaed in this format using this function
        /// </summary>
        /// <returns></returns>
        public override string getSummary()
        {
            return "Income from " + source + " : $" + Amount;
        }

    }
}