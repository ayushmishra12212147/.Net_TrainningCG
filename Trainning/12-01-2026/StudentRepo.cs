using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    public class StudentRepo
    {
        static List<Student> studList = null;
        public StudentRepo() {
            if (studList == null)
            {
                studList = new List<Student>()
                {
                    new Student() { RollNo = 101, Name = "Amit", Gender = "Male", Marks = 80, Fees=14000 },
                    new Student() { RollNo = 102, Name = "Aman", Gender = "Male", Marks = 65, Fees=13000  },
                    new Student() { RollNo = 103, Name = "Amrita", Gender = "Female", Marks = 75, Fees=18000  },
                    new Student() { RollNo = 104, Name = "Amey", Gender = "Male", Marks = 90, Fees=20000  },
                    new Student() { RollNo = 105, Name = "Amit", Gender = "Male", Marks = 80, Fees=8000  },
                    new Student() { RollNo = 106, Name = "Amita", Gender = "Female", Marks = 79, Fees=2000  },
                };


                }
        }
        public List<Student> GetAllStudents()
        {
            return studList;

        }
    }
}
