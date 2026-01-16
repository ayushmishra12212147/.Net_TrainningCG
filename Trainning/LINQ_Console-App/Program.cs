using System;

int num1=100;
int num2=200;
int numResult=num1+num2;
System.Console.WriteLine(numResult);


Employee emp=new Employee();
emp.BSalary=40000;
emp.EmpID=123;
emp.EmpName="Alok";

Employee emp1=new Employee();
emp1.BSalary=35000;
emp1.EmpID=123;
emp1.EmpName="Alok";

Employee emp3=new Employee();
emp3.BSalary=30000;
emp3.EmpID=123;
emp3.EmpName="Alok";

Employee empObj=emp+emp1;

Employee empObj1=emp+emp1+emp3;//We can do n number of additions , it is done 

System.Console.WriteLine($"Total Salary Paid {empObj1.BSalary}");



MyLogic m1=new MyLogic();
//by this 1 object we can call 2 methods which are in 2 different files (Demofile1 and Demofile2) as the class is a partial class 
//so in order to work on 1 class by 2 different people a class can be made partiall class making it easy for developers to work
//on a single project in a very efficient way 
