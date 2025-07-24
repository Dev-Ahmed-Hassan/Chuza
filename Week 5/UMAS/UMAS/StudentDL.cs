using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class StudentDL
    {
        static List<StudentBL > students = new List<StudentBL>();   

        static  public List<StudentBL> ShowStudent()
        {
            return students;
        }

        static public List<StudentBL> stuDeg(string name)
        {
            List<StudentBL> temp = new List<StudentBL>();
            foreach (StudentBL student in students)
            {
                if(student.degree.name == name)
                {
                    temp.Add(student);
                }
            }
            return temp;
        }

        static public void AddStudent(StudentBL s)
        {
            students.Add(s);
        }

        static public bool CheckStudentByName (string name)
        {
            bool flag = false;
            foreach (StudentBL s in students)
            {
                if(name == s.name)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}