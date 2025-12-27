using System;
namespace Test1{
    public class PatientBill
    {
        /// <summary>
        /// All entity requied for the program 
        /// Note:- Not following proper Casing because question has this casing
        /// </summary>
        public string? BillId{get;set;}
        public string? PatientName{get;set;}
        public bool HasInsurance{get;set;}
        public double Consultationfee{get;set;}
        public double LabCharges{get;set;}
        public double MedicineCharges{set;get;}
        double GrossAmount{set;get;}
        double DisccountAmount{set;get;}
        double FinalPayable{set;get;}
        static bool hasLastBill=false;
        



        public void createNewBill()
        {
            System.Console.WriteLine("Enter Bill ID");
            string? billIdByUser=Console.ReadLine();
            if (billIdByUser != null)
            {
                BillId=billIdByUser;
            }
            else
            {
                System.Console.WriteLine("Bill Id Cannot be Null");
                return;
            }
            System.Console.WriteLine("Enter Patient Name");
            PatientName=Console.ReadLine();


            System.Console.WriteLine("Is the patient insured? {Y/N}");
            Char insured=Convert.ToChar(Console.ReadLine());

            if (insured == 'Y')
            {
                HasInsurance=true;

            }
            else
            {
                HasInsurance=false;
            }

            System.Console.WriteLine("Enter COnsultation Fee.");
            double cFee=Convert.ToDouble(Console.ReadLine());


            if (cFee > 0)
            {
                Consultationfee=cFee;
            }
            else
            {
                System.Console.WriteLine("Consultation Fee cannot be less than or equal to 0");
                return;


            }


            System.Console.WriteLine("Enter Lab Charges.");
            double lCharges=Convert.ToDouble(Console.ReadLine());


            System.Console.WriteLine("Enter Medicine Charges.");
            double mCharges=Convert.ToDouble(Console.ReadLine());


            if(lCharges<0 || mCharges < 0)
            {
                System.Console.WriteLine("Lab or Medicine chages cannot be less than 0");
                return;
            }
            Consultationfee=cFee;
            LabCharges=lCharges;
            MedicineCharges=mCharges;





            GrossAmount=Consultationfee+LabCharges+MedicineCharges;
            hasLastBill=true;

            if (HasInsurance)
            {
                DisccountAmount=GrossAmount*0.1;
            }
            else
            {
                DisccountAmount=0;
            }
            FinalPayable=GrossAmount-DisccountAmount;


            System.Console.WriteLine("Bill Created Successfully.");
            System.Console.WriteLine("Gross Amount: {0}\nDiscount Amount: {1}\nFinal Payable: {2}",GrossAmount,DisccountAmount,FinalPayable);
            System.Console.WriteLine("-----------------------------------------------------");

        }
        public void ViewLastBill()
        {

            if (!hasLastBill)
            {
                System.Console.WriteLine("No Bill To show");
                return;
            }
            System.Console.WriteLine("--------------Last Bill------------------");
            System.Console.WriteLine("BillId: {0}\nPatient: {1}\nInsured: {2}\nConsultation Fee: {3} ",BillId,PatientName,HasInsurance,Consultationfee);
            System.Console.WriteLine("Lab Charges: {0}",LabCharges);
            System.Console.WriteLine("Medicine Charges: {0}",MedicineCharges);
            System.Console.WriteLine("Gross Amount: {0}",GrossAmount);
            System.Console.WriteLine("Discount Amount: {0}",DisccountAmount);
            System.Console.WriteLine("Final Payable: {0}",FinalPayable);
            
        }

        public void ClearLastBill()
        {
            if (hasLastBill)
            {
               GrossAmount=0;
               DisccountAmount=0;
               FinalPayable=0;
               hasLastBill=false;

            }
            else
            {
                System.Console.WriteLine("No bill Available Please Create a bill");
            }
        }
    }
}