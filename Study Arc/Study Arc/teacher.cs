using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Arc
{
    internal class teacher
    {
        public string userName;
        public string password;
       

        public List<string> Mycourses = new List<string>();

        public teacher(string user, string pass)
        {
            this.userName = user;
            this.password = pass;
        }

        public bool LaunchCourse(string code, List<course> courses)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Code == code)
                {
                    return false;
                }
            }
            course s = new course(code);
            s.CourseTeacher = userName;
            courses.Add(s);
            Mycourses.Add(code);
            return true;
        }

        public bool DeleteCourse(string code, List<course> arr, List<student> stu)
        {
            if (!Mycourses.Contains(code))
            {
                return false;
            }
            foreach (course c in arr)
            {
                if (c.Code == code)
                {
                    arr.Remove(c);
                    foreach (student s in stu)
                    {
                        if(c.EnrolledStudents.Contains(s.userName))
                        {
                            s.courses.Remove(c.Code);
                        }
                    }
                }
            }
            return true;
        }

        
    }
}
