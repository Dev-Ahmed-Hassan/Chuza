using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;

namespace Study_Arc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            general g = new general();
            List<student> students = new List<student>();
            List<course> courses = new List<course>();
            List<teacher> teachers = new List<teacher>();
            List<admin> admins = new List<admin>();
            g.load("data.txt", students, teachers,admins);

            string CurrentState = "MainMenu";
            string ActiveUser = "";
            student ActiveStudent = students[0];
            teacher ActiveTeacher = teachers[0];
            admin ActiveAdmin = admins[0];

            while (CurrentState != "Exit") 
            {
                while(CurrentState == "MainMenu")
                {
                    int option = MainOption();
                    if (option == 1) { CurrentState = "In"; }
                    else if (option == 2) { CurrentState = "Up"; }
                    else if (option == 3) { CurrentState = "Exit"; }
                }

                while (CurrentState == "In")
                {
                    Console.Write("Enter UserName: ");
                    string user = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string pass = Console.ReadLine();


                    string UserType = g.SignIn(user, pass, students, teachers, admins, ref ActiveUser, ref ActiveStudent, ref ActiveTeacher, ref ActiveAdmin);

                    if (UserType == "None")
                    {
                        Console.WriteLine("Your User Is not registered!");
                        CurrentState = "MainMenu";
                        Console.ReadKey();
                    }
                    else if(UserType == "student")
                    {
                        CurrentState = "StudentMenu";
                    }
                    else if (UserType == "teacher")
                    {
                        CurrentState = "TeacherMenu";
                    }
                    else if (UserType == "admin")
                    {
                        CurrentState = "AdminMenu";
                    }
                    
                }

                while(CurrentState == "Up")
                {
                    string user, pass, type;

                    Console.Write("Enter UserName: ");
                    user = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    pass = Console.ReadLine();
                    Console.Write("Enter UserType: ");
                    type = Console.ReadLine();

                    string temp = g.SignUp(user, pass, type, students,teachers, admins, ref ActiveUser);

                    if (temp == "None") {Console.WriteLine("Your UserName is Already Registered!"); CurrentState = "MainMenu"; }
                    else if (temp == "student") 
                    { 
                        CurrentState = "StudentMenu";
                        student s = new student(user, pass);
                        students.Add(s);
                        ActiveStudent = s;
                    }
                    else if  (temp == "teacher") 
                    { 
                        CurrentState = "TeacherMenu";
                        teacher t = new teacher(user,pass);
                        teachers.Add(t);
                        ActiveTeacher = t;
                    }
                    else if (temp == "admin") 
                    { 
                        CurrentState = "AdminMenu";
                        admin a = new admin(user, pass);
                        admins.Add(a);
                        ActiveAdmin = a;
                    }

                }

                while(CurrentState == "StudentMenu")
                {
                    int option = StudentOption();
                    if (option == 1)
                    {
                        Console.Write("Enter Course Code: ");
                        string code = Console.ReadLine();
                        int temp = ActiveStudent.Enroll(code, courses);
                        if (temp == -1) { Console.WriteLine("You are already Enrolled in this Course!"); Console.ReadKey(); CurrentState = "StudentMenu"; }
                        else if (temp == 1) { Console.WriteLine("You have been successfully Enrolled in {0}", code); Console.ReadKey(); CurrentState = "StudentMenu"; }
                        else if (temp == 0) { Console.WriteLine("{0} is not a course!", code); Console.ReadKey(); CurrentState = "StudentMenu"; }
                    }
                    else if (option == 2)
                    {
                        Console.Write("Enter Course Code: ");
                        string code = Console.ReadLine();
                        bool temp = ActiveStudent.DeRoll(code, courses);
                        if (temp) { Console.WriteLine("You have been successfully derolled from {0}", code); Console.ReadKey(); CurrentState = "StudentMenu"; }
                        else { Console.WriteLine("You are not Enrolled in this Course!"); Console.ReadKey(); CurrentState = "StudentMenu"; }
                    }
                    else if (option == 3)
                    {
                        ActiveStudent.ShowCourse(courses);
                        Console.ReadKey();
                        CurrentState = "StudentMenu";
                    }
                    else if (option == 4)
                    {
                        CurrentState = "MainMenu";
                    }
                }
                while(CurrentState == "TeacherMenu")
                {
                    int option = TeacherOption();
                    if (option == 1)
                    {
                        Console.Write("Enter Course Code: ");
                        string code = Console.ReadLine();
                        bool temp = ActiveTeacher.LaunchCourse(code, courses);
                        if (temp) { Console.WriteLine("Your Course has been Launched!"); Console.ReadKey(); CurrentState = "TeacherMenu"; }
                        else { Console.WriteLine("The Course Already Exists!"); Console.ReadKey(); CurrentState = "TeacherMenu"; }
                    }
                    else if (option == 2)
                    {
                        Console.Write("Enter Course Code: ");
                        string code = Console.ReadLine();
                        bool temp = ActiveTeacher.DeleteCourse(code, courses, students);
                        if (temp) { Console.WriteLine("Your Course Has Been Deleted!"); Console.ReadKey(); CurrentState = "TeacherMenu"; }
                        else { Console.WriteLine("You have not Launched {0}", code); Console.ReadKey(); CurrentState = "TeacherMenu"; }
                    }
                    else if (option == 3)
                    {
                        CurrentState = "MainMenu";
                    }
                }
                while(CurrentState == "AdminMenu")
                {
                    int option = AdminOption();
                    if (option == 1) { CurrentState = "Add"; }
                    else if (option == 2) { CurrentState = "Remove"; }
                    else if (option == 3) { CurrentState = "Show"; }
                    else if (option == 4) { CurrentState = "MainMenu"; }

                }
                while(CurrentState == "Add")
                {
                    int option = AddOption();
                    if (option == 1)
                    {
                        Console.Write("Enter User Name: ");
                        string user = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        string pass = Console.ReadLine();

                        bool temp = ActiveAdmin.AddStudent(user, pass, students);
                        if (temp) { Console.WriteLine("Your User Is Added!");Console.ReadKey(); CurrentState = "Add"; }
                        else { Console.WriteLine("Your User Already Exists!"); Console.ReadKey(); CurrentState = "Add"; }
                    }
                    else if (option == 2)
                    {
                        Console.Write("Enter User Name: ");
                        string user = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        string pass = Console.ReadLine();

                        bool temp = ActiveAdmin.AddTeacher(user, pass, teachers);
                        if (temp) { Console.WriteLine("Your User Is Added!"); Console.ReadKey(); CurrentState = "Add"; }
                        else { Console.WriteLine("Your User Already Exists!"); Console.ReadKey(); CurrentState = "Add"; }
                    }
                    else if (option == 3)
                    {
                        Console.Write("Enter User Name: ");
                        string user = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        string pass = Console.ReadLine();

                        bool temp = ActiveAdmin.AddAdmin(user, pass, admins);
                        if (temp) { Console.WriteLine("Your User Is Added!"); Console.ReadKey(); CurrentState = "Add"; }
                        else { Console.WriteLine("Your User Already Exists!"); Console.ReadKey(); CurrentState = "Add"; }
                    }
                    else if( option == 4)
                    {
                        Console.Write("Enter Course Code: ");
                        string code = Console.ReadLine();
                        Console.Write("Enter Course Teacher Name: ");
                        string teach = Console.ReadLine();

                        bool temp = ActiveAdmin.AddCourse(code, courses, teach);
                        if (temp) { Console.WriteLine("Your Course Is Added!"); Console.ReadKey(); CurrentState = "Add"; }
                        else { Console.WriteLine("Your Course Already Exists!"); Console.ReadKey(); CurrentState = "Add"; }
                    }
                    else if (option == 5) { CurrentState = "AdminMenu"; }
                }
                while (CurrentState == "Remove")
                {
                    int option = RemOpt();
                    if(option == 1)
                    {
                        Console.Write("Enter User Name: ");
                        string user = Console.ReadLine();

                        bool temp = ActiveAdmin.RemoveStudent(user,students, courses);

                        if(temp) { Console.WriteLine("Your User Has Been Removed!");Console.ReadKey(); CurrentState = "Remove"; }
                        else { Console.WriteLine("Your User Does Not Exist!"); Console.ReadKey(); CurrentState = "Remove";  }
                    }
                    else if(option == 2)
                    {
                        Console.Write("Enter User Name: ");
                        string user = Console.ReadLine();

                        bool temp = ActiveAdmin.RemoveTeacher(user, teachers, courses, students);

                        if (temp) { Console.WriteLine("Your User Has Been Removed!"); Console.ReadKey(); CurrentState = "Remove"; }
                        else { Console.WriteLine("Your User Does Not Exist!"); Console.ReadKey(); CurrentState = "Remove"; }
                    }
                    else if(option == 3)
                    {
                        Console.Write("Enter User Name: ");
                        string user = Console.ReadLine();

                        bool temp = ActiveAdmin.RemoveAdmin(user,admins);

                        if (temp) { Console.WriteLine("Your User Has Been Removed!"); Console.ReadKey(); CurrentState = "Remove"; }
                        else { Console.WriteLine("Your User Does Not Exist!"); Console.ReadKey(); CurrentState = "Remove"; }
                    }
                    else if(option == 4)
                    {
                        Console.Write("Enter Course Code: ");
                        string code = Console.ReadLine();
                        bool temp = ActiveAdmin.DeleteCourse(code, courses, teachers, students);
                        if (temp) { Console.WriteLine("Your Course Has Been Removed!"); Console.ReadKey(); CurrentState = "Remove"; }
                        else { Console.WriteLine("Your Course Does Not Exist!"); Console.ReadKey(); CurrentState = "Remove"; }

                    }
                    else if (option == 5)
                    {
                        CurrentState = "AdminMenu";
                    }
                }
                while(CurrentState == "Show")
                {
                    int option = ShowOpt();
                    if(option == 1)
                    {
                        ActiveAdmin.ShowStudent(students);
                        Console.ReadKey();
                    }
                    else if(option == 2)
                    {
                        ActiveAdmin.ShowTeacher(teachers);
                        Console.ReadKey();
                    }
                    else if(option == 3)
                    {
                        ActiveAdmin.ShowCourses(courses);
                        Console.ReadKey();
                    }
                    else if(option == 4)
                    {
                        CurrentState = "AdminMenu";
                    }

                }
            }
        }

        static int ShowOpt()
        {
            int option = 0;
            while (option < 1 || option > 4)
            {
                Console.Clear();
                Console.WriteLine(" ===================  Show Menu  =======================");
                Console.WriteLine("1. Show Students");
                Console.WriteLine("2. Show Teachers");
                Console.WriteLine("3. Show Courses");
                Console.WriteLine("4. Back");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }

            return option;
        }
        static int RemOpt()
        {
            int option = 0;
            while (option < 1 || option > 5)
            {
                Console.Clear();
                Console.WriteLine(" ===================  Remove Menu  =======================");
                Console.WriteLine("1. Remove Student");
                Console.WriteLine("2. Remove Teacher");
                Console.WriteLine("3. Remove Admin");
                Console.WriteLine("4. Remove Course");
                Console.WriteLine("5. Back");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }

            return option;
        }
        static int AddOption()
        {
            int option = 0;
            while (option < 1 || option > 5)
            {
                Console.Clear();
                Console.WriteLine(" ===================  Add Menu  =======================");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. Add Admin");
                Console.WriteLine("4. Add Course");
                Console.WriteLine("5. Back");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }

            return option;
        }
        static int AdminOption()
        {
            int option = 0;
            while (option < 1 || option > 4)
            {
                Console.Clear();
                Console.WriteLine(" ===================  Admin Menu  =======================");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. Show");
                Console.WriteLine("4. Logout");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }

            return option;
        }
        static int TeacherOption()
        {
            int option = 0;
            while (option < 1 || option > 3)
            {
                Console.Clear();
                Console.WriteLine(" ===================  Teacher Menu  =======================");
                Console.WriteLine("1. Launch Course");
                Console.WriteLine("2. Delete Course");
                Console.WriteLine("3. Log out");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }

            return option;
        }
        static int StudentOption()
        {
            int option = 0;
            while (option < 1 || option > 4)
            {
                Console.Clear();
                Console.WriteLine(" ===================  Student Menu  =======================");
                Console.WriteLine("1. Enroll in a Course");
                Console.WriteLine("2. Deroll from a Course");
                Console.WriteLine("3. Show Enrolled Courses");
                Console.WriteLine("4. Log out");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }

            return option;
        
        }
        static int MainOption()
        {
            int option = 0;
            while (option < 1 || option > 3)
            {
                Console.Clear();
                Console.WriteLine(" ===================  Main Menu  =======================");
                Console.WriteLine("1. Sign In");
                Console.WriteLine("2. Sign Up");
                Console.WriteLine("3. Exit");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }

            return option;
        }
    }
}
