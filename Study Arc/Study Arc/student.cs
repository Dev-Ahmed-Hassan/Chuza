using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Arc
{
    internal class student
    {
        public string userName;
        public string password;

        public List<string> courses = new List<string>();

        public student(string user, string pass)
        {
            this.userName = user;
            this.password = pass;
        }

        public int Enroll(string code, List<course> arr)  
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == code)
                {
                    return -1; // already enrolled.
                }
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Code == code)
                {
                    arr[i].EnrolledStudents.Add(this.userName);
                    return 1;
                }
            }
            return 0;
        }

        public bool DeRoll(string code, List<course> arr)
        {
            if(courses.Contains(code))
            {
                courses.Remove(code);
                foreach (course n in arr)
                {
                    if (n.Code == code)
                    {
                        n.EnrolledStudents.Remove(this.userName);
                        return true;
                    }
                }
            }
            return false;
        }


        public void ShowCourse(List<course> cor)
        {
            int idx = 1;
            foreach(string c in courses)
            {
                foreach(course c2 in cor)
                {
                    if(c == c2.Code)
                    {
                        Console.WriteLine("{0}.  {1}    {2}",idx,c2.Code,c2.CourseTeacher);
                    }
                }
                idx++;
            }
        }
    }


}
