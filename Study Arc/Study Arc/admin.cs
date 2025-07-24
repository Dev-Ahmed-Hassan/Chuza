using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Arc
{
    internal class admin
    {
        public string username;
        public string password;

        public admin(string userName, string password) 
        { 
            this.username = userName;
            this.password = password;
        }

        public bool AddStudent(string user,string password, List<student> arr)
        {
            foreach (student s in arr)
            {
                if(s.userName == user)
                {
                    return false;
                }
            }
            student p = new student(user,password);
            arr.Add(p);
            return true;
        }
        public bool RemoveStudent(string user, List<student> arr, List<course> cor)
        {
            foreach (student s in arr)
            {
                if (s.userName == user)
                {
                    arr.Remove(s);
                    foreach(course c in cor)
                    {
                        if(c.EnrolledStudents.Contains(s.userName))
                        {
                            c.EnrolledStudents.Remove(s.userName);
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public bool AddTeacher(string user, string password, List<teacher> arr)
        {
            foreach (teacher s in arr)
            {
                if (s.userName == user)
                {
                    return false;
                }
            }
            teacher p = new teacher(user, password);
            arr.Add(p);
            return true;
        }
        public bool RemoveTeacher(string user, List<teacher> arr, List<course> cor, List<student> stu)
        {
            foreach (teacher s in arr)
            {
                if (s.userName == user)
                {
                    arr.Remove(s);
                    foreach(course c in cor)
                    {
                        if(c.CourseTeacher ==  s.userName)
                        {
                            cor.Remove(c);
                            foreach (student t in stu)
                            {
                                if (c.EnrolledStudents.Contains(t.userName))
                                {
                                    t.courses.Remove(c.Code);
                                }
                            }
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public bool AddAdmin(string user, string password, List<admin> arr)
        {
            foreach (admin s in arr)
            {
                if (s.username == user)
                {
                    return false;
                }
            }
            admin p = new admin(user, password);
            arr.Add(p);
            return true;
        }
        public bool RemoveAdmin(string user, List<admin> arr)
        {
            foreach (admin s in arr)
            {
                if (s.username == user)
                {
                    arr.Remove(s);
                    return true;
                }
            }
            return false;
        }

        public bool AddCourse(string code, List<course> arr, string CourseTeacher)
        {
            foreach (course s in arr)
            {
                if (s.Code == code)
                {
                    return false;
                }
            }
            course x = new course(code, CourseTeacher);
            arr.Add(x);
            return true;
        }

        public bool DeleteCourse(string code, List<course> arr, List<teacher> teh, List<student> stu)
        {
            foreach (course c in arr)
            {
                if (c.Code == code)
                {
                    arr.Remove(c);
                    foreach(teacher t in teh)
                    {
                        if (t.userName == c.CourseTeacher)
                        {
                            if(t.Mycourses.Contains(code))
                            {
                                t.Mycourses.Remove(code);
                            }
                        }
                    }
                    foreach(student s in stu)
                    {
                        if (c.EnrolledStudents.Contains(s.userName))
                        {
                            s.courses.Remove(code);
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public void ShowStudent(List<student> stu)
        {
            foreach(student s in stu)
            {
                Console.Write("Name: {0}    Password: {1}    Courses Enrolled: ",s.userName,s.password);
                foreach(string c in s.courses)
                {
                    Console.Write(" {0} ",c);  
                }
                Console.Write("\n");
            }
        }

        public void ShowTeacher(List<teacher> tec)
        {
            foreach (teacher t in tec)
            {
                Console.Write("Name: {0}    Password: {1}    Courses Made: ", t.userName, t.password);
                foreach (string c in t.Mycourses)
                {
                    Console.Write(" {0} ", c);
                }
                Console.Write("\n");
            }
        }

        public void ShowCourses(List<course> cor)
        {
            foreach(course c in cor)
            {
                Console.Write("Course Code: {0}    Teacher Name: {1}    Enrolled Students: ",c.Code, c.CourseTeacher );
                foreach(string s in c.EnrolledStudents)
                {
                    Console.Write(s);
                }
                Console.Write("\n");
            }
        }

    }
}
