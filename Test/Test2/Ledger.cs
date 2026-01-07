using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace Test2
{
    public class Ledger<T> where T : Transaction
    {
        private List<T> Alltransactions=new List<T>();
        /// <summary>
        /// to dd the entry of transaction into ledger
        /// </summary>
        /// <param name="enrty"></param>
        public void AddEntry(T enrty)
        {
            Alltransactions.Add(enrty);
        }


        public List<T> GetTransactionByDate(DateTime date)
        {
            List<T> Result=new List<T>();
            foreach(T trans in Alltransactions)
            {
                if (trans.dateTime.Date == date.Date)
                {
                    Result.Add(trans);
                }
                
            }


            return Result;
        }





        public double CalculateTotal()
        {
            double sum=0;
            foreach(T trans in Alltransactions)
            {
                sum+=trans.Amount;
            }

            return sum;
        }


        /// <summary>
        /// This will be used when all transactons listing will be done.
        /// </summary>
        /// <returns></returns>
        public List<T> getAll()
        {
            return Alltransactions;
        }
    }
}