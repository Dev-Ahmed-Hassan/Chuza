using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class StudentUI
    {

        static public string getdeg()
        {
            Console.Write("Enter Degree: ");
            return Console.ReadLine();
        }
        static public StudentBL AddStudent()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            bool found = StudentDL.CheckStudentByName(name);
            if (found)
            {
                Console.WriteLine("Student Already Exists!");
                return null;
            }
            else {
            Console.WriteLine("Enter Age: ");
            int Age = int . Parse(Console.ReadLine());
            Console.WriteLine("Enter FSC Marks: ");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ECAT Marks: ");
            float e = float.Parse(Console.ReadLine());

                StudentBL s = new StudentBL(name, Age, f, e);
                return s;
            }
        }


        static public void ShowStudent(List<StudentBL> s)
        {
            foreach (StudentBL stu in s)
            {
                Console.WriteLine($"Name: {stu.name}, Age: {stu.age}");
            }
        }

        static public void ShowSorrow()
        {
            Console.WriteLine("Still Working on it!"); ;
        }
    }
}
