using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class Student
    {
        public string name;
        public int age;
        public float FSCMarks;
        public float ECATMarks;
        public List<Degree> preferences = new List<Degree>();
        public List<Subject> RegisteredSubjects = new List<Subject>();
        public Degree degree;

        public Student(string name, int age, float f, float e)
        {
            this.name = name;
            this.age = age;
            this.FSCMarks = f;
            this.ECATMarks = e;
        }
        public void showStudent()
        {
            Console.WriteLine($"{name}, {FSCMarks}, {ECATMarks}, {age}");
        }
        public float CalculateFees()
        {
            float sum = 0;
            foreach (Subject sub in degree.s)
            {
                sum += sub.SubjectFees;
            }
            foreach (Subject sub in RegisteredSubjects)
            {
                sum += sub.SubjectFees;
            }
            return sum;
        }

    }
}
