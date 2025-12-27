using System;
namespace Day2DemoConsole;
public class Student
{
    #region Fields
    int rollNo;
    string name;
    string addr;
    #endregion
    /// <summary>
    /// Default constructor for Student class
    /// </summary>
    public Student()
    {
        rollNo=100;
        name="Dummy";
        addr="Dummy City";
        
    }





    /// <summary>
    /// Paremetrized constructor for Student Class
    /// </summary>
    public Student(int id,string name,string city)
    {
        this.name=name;
        this.addr=city;
        rollNo=id;
    }
    public void DisplayDetails(Student s1)
    {
        System.Console.WriteLine(" Roll No:{0}\n Name: {1}\n Address:{2}",s1.rollNo,s1.name,s1.addr);

    }



}
