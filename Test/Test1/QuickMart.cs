using System;
namespace Test1
{
    public class QuickMart
    {
        /// <summary>
        /// All entity requied for the program 
        /// Note:- Not following proper Casing because question has this casing
        /// </summary>
        public string InvoiceNo{set;get;}
        public string CustomerName{set;get;}
        public string ItemName{set;get;}
        public int Quantity{set;get;}
        public double PurchaseAmount{set;get;}
        public double SellingAmount{get;set;}
        string ProfitOrLossStatus{get;set;}
        double ProfitOrLossAmount{set;get;}
        double ProfitMarginPercent{set;get;}
        static bool HasLastTransaction=false;




        public void createNewTransaction()
        {
            System.Console.WriteLine("Enter Invoice Number");
            string? invoiceReciever=Console.ReadLine();
            if (invoiceReciever == null)
            {
                System.Console.WriteLine("Invoice Cannot be null");
                return;
            }
            InvoiceNo=invoiceReciever;


            System.Console.WriteLine("Enter Customer Name");
            CustomerName=Console.ReadLine();






            System.Console.WriteLine("Enter Item Name");
            ItemName=Console.ReadLine();



            System.Console.WriteLine("Enter Quantity");
            int quant=Convert.ToInt32(Console.ReadLine());
            if (quant <= 0)
            {
                System.Console.WriteLine("Quantity Cannot be less than or Equal to 0");
                return;
            }

            System.Console.WriteLine("Enter Purchase Amount");
            int purchase=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Sale Amount");
            int Sale=Convert.ToInt32(Console.ReadLine());



            if (purchase <= 0)
            {
                System.Console.WriteLine("Invalid Purchase Amount");
                return;
            }
            if (Sale < 0)
            {
                System.Console.WriteLine("Invalid Sale Amount");
                return;
            }
            PurchaseAmount=purchase;

            SellingAmount=Sale;


            calculate();


            
            
        }



        public void viewLastTransaction()
        {
            if (!HasLastTransaction)
            {
                System.Console.WriteLine("No Last transaction. Please Create a new transaction.");

            }
            else
            {
                System.Console.WriteLine("------------Last Transaction -------------------");
                System.Console.WriteLine("InvoiceNo: {0}",InvoiceNo);
                System.Console.WriteLine("Customer: {0}",CustomerName);
                System.Console.WriteLine("Item: {0}",ItemName);
                System.Console.WriteLine("Quantity: {0}",Quantity);
                System.Console.WriteLine("Purchase Amount: {0}",PurchaseAmount);
                System.Console.WriteLine("Selling Amount: {0}",SellingAmount);
                System.Console.WriteLine("Status: {0}",ProfitOrLossStatus);
                System.Console.WriteLine("Profit/Loss Amount: {0}",ProfitOrLossAmount);
                System.Console.WriteLine("{0} Margin(%): {1}",ProfitOrLossStatus,ProfitMarginPercent);
                System.Console.WriteLine("-----------------------------------------------------------");
            }
            
        }


        public void calculate()
        {
            if (SellingAmount > PurchaseAmount)
            {
                ProfitOrLossStatus="Profit";
                ProfitOrLossAmount=SellingAmount-PurchaseAmount;
            }
            else if(SellingAmount<PurchaseAmount)
            {
                ProfitOrLossStatus="Loss";
                ProfitOrLossAmount=PurchaseAmount-SellingAmount;
            }
            else
            {
                ProfitOrLossStatus="Break-Even";
                ProfitOrLossAmount=0;
                
            }


            

            ProfitMarginPercent=(ProfitOrLossAmount/PurchaseAmount)*100;




            System.Console.WriteLine("Status: {0}",ProfitOrLossStatus);
            System.Console.WriteLine("Profit/Loss Amount: {0}",ProfitOrLossAmount);
            HasLastTransaction=true;




            System.Console.WriteLine("{0} Margin(%): {1}",ProfitOrLossStatus,ProfitMarginPercent);



            
        }
    }
}