// See https://aka.ms/new-console-template for more information

// static void menu()
// {
//     System.Console.WriteLine("1. Add Student Details");
//     System.Console.WriteLine("2. Update Student Details");
//     System.Console.WriteLine("3. Delete Student Details");
//     System.Console.WriteLine("4. Edit Student Details");

// }
// Student sObj=new Student(123,"Alok","Delhi");

// sObj.DisplayDetails(sObj);

// sObj=new Student(123,"Alok","Chennai");
// sObj.DisplayDetails(sObj);


//string[] cities = { "Pune", "Chennai", "Agra", "Mumbai", "Hyderabad" };
// int i=0;
// while (i<cities.Length){
//     System.Console.WriteLine(cities[i]);
//     i++;

// }

//Same using For each
//if we want to just print we use this, to add data with printing we can use for loop only

// foreach (var item in cities)
// {
//     System.Console.WriteLine(item);
// }


// int choice = 0;
// do
// {
//     menu();
//     System.Console.WriteLine("Enter Your Choice.....");
//     choice=Int32.Parse(Console.ReadLine());
//     switch (choice)
//     {
//         case 1:
//             {
//                 break;
//             }
//         case 2:
//             {
//                 break;
//             }
//     }
// } while (true);



using System;
using Day2DemoConsole;
public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Which Program you want to run.....?");
        System.Console.WriteLine("1. Height Category");
        System.Console.WriteLine("2. Largest of Three");
        System.Console.WriteLine("3. Leap Year Checker");
        System.Console.WriteLine("4. Quadratic Equation");
        System.Console.WriteLine("5. Admission Eligibility");
        System.Console.WriteLine("6. Electricity Bill");
        System.Console.WriteLine("7. Vowel or Consonant");
        System.Console.WriteLine("8. Triangle Type");
        System.Console.WriteLine("9. Quadrant Finder");
        System.Console.WriteLine("10. Grade Description");
        System.Console.WriteLine("11. Valid Date Check");
        System.Console.WriteLine("12. ATM Withdrawal");
        System.Console.WriteLine("13. Profit/Loss");
        System.Console.WriteLine("14. Rock Paper Scissors");
        System.Console.WriteLine("15. Simple Calculator");
        System.Console.WriteLine("Enter here ...........");
        string? input=Console.ReadLine();
        if(!int.TryParse(input,out int num))
        {
            System.Console.WriteLine("Not Valid.....");
            return;
        }
        switch (num)
        {
            case 1:
                {
                    Height.heightMain();
                    break;
                }
            case 2:
                {
                    Largest.LargestMain();
                    break;
                }
            case 3:
                {
                    Leap.leapMain();
                    break;
                }
            case 4:
                {
                    Roots.rootMain();
                    break;
                }
            case 5:
                {
                    Admission.admissionMain();
                    break;
                }
            case 6:
                {
                    Bill.billMain();
                    break;
                }
            case 7:
                {
                    Vowel.vowelMain();
                    break;
                }
            case 8:
                {
                    Triangle.triangleMain();
                    
                    break;
                }
            case 9:
                {
                    Quadrant.QuadrantMain();
                    break;
                }
            case 10:
                {
                    Grade.gradeMain();
                    break;
                }
            case 11:
                {
                    DateCheck.datecheckMain();
                    
                    break;
                }
            case 12:
                {
                    Atm.atmMain();
                    break;
                }
            case 13:
                {
                    ProfitLoss.profitLossMain();
                    
                    break;
                }
            case 14:
                {
                    RockPaperScissor.RockPaperScissorMain();
                    
                    break;
                }
            case 15:
                {
                    Operator.operatorMain();
                    
                    break;
                } 
            case 16:
                {
                    Fib.fibMain();
                    break;
                }

            case 17:
                {
                    Prime.primeMain();
                    break;
                }
            case 18:
                {
                    Armstrong.armMain();
                    break;
                }
            case 19:
                {
                    Pallindrome.palMain();
                    break;
                }
            case 20:
                {
                    GcdLcm.GcdLcmMain();
                    break;
                }
            case 21:
                {
                    PascalTriangle.pascalMain();
                    break;
                }
            case 22:
                {
                    B2d.bMain();
                    break;
                }
            case 23:
                {
                    Diamond.diamondMain();
                    break;
                }
            case 24:
                {
                    Factorial.FactMain();
                    break;
                }
            case 25:
                {
                    Guess.guessMain();
                    break;
                    
                }
            case 26:
                {
                    //not done yet
                    break;
                    
                }
            case 27:
                {
                    Skip3.skipMain();
                    break;
                    
                }
            case 28:
                {
                     Menu.menuMain();
                    break;
                }

            case 29:
                {
                    //not done yet
                    
                    break;
                }
            case 30:
                {
                    //not done yet
                    break;
                   
                }
            
            
        }
    }
}