using System;

namespace Test2
{
    public abstract class Transaction : IReportable
    {
        /// <summary>
        /// The properties are declared here , these peoperties are required for all trancations.
        /// </summary>
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public double Amount { get; set; }
        public string DiscriptionOfTransaction { get; set; }
        public abstract string getSummary();
    }
}