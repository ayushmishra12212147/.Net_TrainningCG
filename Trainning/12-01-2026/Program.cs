using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    class Program
    {
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 45, 65, 23, 66, 48, 8, 27 };
            string[] nameArray = { "Alok", "Rajat", "Sumeet", "Priya", "Ayush", "Harshita", "Himanshu", "Mahi", "Mandabi", "Gaurav", "Yash", "Mahesh", "Teja", "Sai" };
            foreach (var item in numArray) {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"{item} ");
                }

            }

            //Now using LINQ query
            Console.WriteLine("Start of Linq");
            var result = from data in numArray
                          where data % 2 == 0 && data>20
                          select data;


            foreach(var item in result)
            {
                Console.WriteLine($"{item} ");
            }



            Console.WriteLine("Start of Linq");
            var nameSearch = from data in nameArray
                         where data.StartsWith("A") || data.Contains("a")
                             select data;


            foreach (var item in nameSearch)
            {
                Console.WriteLine($"{item} ");
            }


            //using Orderby in LINQ
            Console.WriteLine("Sorted using OrderBy");
            var nameSearch1 = from data in nameArray
                             orderby data
                             //orderby data descending
                              select data;


            foreach (var item in nameSearch1)
            {
                Console.WriteLine($"{item} ");
            }


        }

        public static void LinqTOObjectDemoOnCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer{ CustomerId=101, Name="Alok", City="Pune"},//object initializer syntax
                new Customer(){ CustomerId=102, Name="Alia", City="Mumbai"},//without bracket also it works fine in new versions
                new Customer{ CustomerId=103, Name="Dheeraj", City="Pune"},
                new Customer{ CustomerId=104, Name="Danish", City="Pune"},
                new Customer{ CustomerId=105, Name="Smita", City="Delhi"},
                new Customer{ CustomerId=106, Name="Naveen", City="Pune"},
                new Customer{ CustomerId=107, Name="Prachi", City="Delhi"},
                new Customer{ CustomerId=108, Name="Megha", City="Mumbai"},
            };

            //3 Methods
            //1st
            var res = custList.Where(cust => cust.City == "Mumbai");//returns all values that matches
            //2nd
            var re=custList.Find(cust=> cust.City == "Mumbai");//returns first match only and cannot be used in foreach loop directly

            var res2= custList.FindAll(cust => cust.City == "Pune");//returns all matches 

            //3rd (using LinQ)
            var result = from cust in custList
                         where cust.City == "Bangalore" || cust.City == "Pune"
                         select new { cust.Name, cust.City, };
        
            foreach(var item in result)
            {
                Console.WriteLine($"Name: {item.Name}, City: {item.City}");
            }



            //anonymous Object
            var data =new {orderId=1100, OrderDate= "12/01/2026", orderAmount=2500 };

        }


        public static void LambdaLookUpStudentList()
        {
            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();
            var result = tempList.ToLookup(stud => stud.Gender == "Male");


            foreach (IGrouping<bool, Student> group in result)
            {
                int totalFee = 0;
                Console.WriteLine("Key: {0}", group.Key);
                foreach (Student stud in group)
                {
                    Console.WriteLine($"{stud.Name}");
                    totalFee+= stud.Fees;

                }
                Console.WriteLine("Total students: {0}", totalFee);
            }
        }




        public static void DrinkSort()
        {
            List<Product> prodList = new List<Product>()
            {
                new Product(){ID=1,Name="Maza",Cost=50,Quantity=2000},
                  new Product(){ID=2,Name="RedBull",Cost=50,Quantity=4000},
                    new Product(){ID=3,Name="Sprite",Cost=150,Quantity=2000},
                      new Product(){ID=4,Name="Coke",Cost=200,Quantity=2000},
                       new Product(){ID=5,Name="Fanta",Cost=30,Quantity=4000}
            };
            Dictionary<string, int> demoDict = new Dictionary<string, int>();
            var itemsList = prodList.GroupBy(item => item.Name == "RedBull")
                .Select(group => new
                {
                    Qty = group.Key,
                    items = group.ToList()
                });
            foreach (var item in itemsList)
            {
                Console.WriteLine("Quantity :{0}", item.Qty);
                demoDict.Add(item.Qty.ToString(), item.items.Count());
                Console.WriteLine($"Items Count {item.items.Count()}");
                int total = 0;
                foreach (var data in item.items)
                {
                    Console.WriteLine(data.Name);
                    total += data.Cost;
                }
                Console.WriteLine($"Total Cost of Products :{total}");
            }
        }
        
        static void Main(string[] args)
        {
            //LinqToObjectDemo();
            //LinqTOObjectDemoOnCustomType();
            //LambdaLookUpStudentList();
            DrinkSort();
        }
    }
}
