using System;
 public class Admission
{
    public static void admissionMain()
    {
        System.Console.WriteLine("Enter your Marks in Math");
        String? input1=Console.ReadLine();
        if(!double.TryParse(input1,out double math))
        {
            System.Console.WriteLine("Marks can only be numbers");
            return;
        }
        System.Console.WriteLine("Enter your Marks in Math");
        String? input2=Console.ReadLine();
        if(!double.TryParse(input2,out double Phys))
        {
            System.Console.WriteLine("Marks can only be numbers");
            return;
        }
        System.Console.WriteLine("Enter your Marks in Math");
        String? input3=Console.ReadLine();
        if(!double.TryParse(input3,out double chem))
        {
            System.Console.WriteLine("Marks can only be numbers");
            return;
        }
        double total =math+chem+Phys;
        if(math>=65 && chem>=55 && Phys>=50 && (total>=180 || math+Phys>140))
        {
            System.Console.WriteLine("Eligible For Admission");
        }
        else
        {
            System.Console.WriteLine("Not Eligible For Admission");
        }
    }
}