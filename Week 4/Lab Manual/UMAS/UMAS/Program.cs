using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CurrentState = "MainMenu";

            List<Student> Students = new List<Student>();
            List<Degree> Degrees = new List<Degree>();
            List<Subject> Subjects = new List<Subject>();

            while(CurrentState != "Exit")
            {
                while(CurrentState == "MainMenu")
                {
                    int option = MainOption();
                    if (option == 1)
                    {
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();
                        bool flag = false;
                        foreach (Student student in Students)
                        {
                            if (student.name == name)
                            {
                                Console.WriteLine("Student Already Exists!");
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            Console.Write("Enter Student Age: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student FSC Marks: ");
                            float Marks = float.Parse(Console.ReadLine());
                            Console.Write("Enter Student Ecat Marks: ");
                            float eMarks = float.Parse(Console.ReadLine());

                            Student s = new Student(name, age, Marks, eMarks);
                            Students.Add(s);
                        }
                    }
                    else if (option == 2)
                    {
                        Console.Write("Enter Degree Name: ");
                        string name = Console.ReadLine();
                        bool flag = false;
                        foreach (Degree d in Degrees)
                        {
                            if (d.name == name)
                            {
                                Console.WriteLine("This Degree Already Exists!");
                                flag = true;
                                break;
                            }
                        }
                        if (!false)
                        {
                            Console.Write("Enter Degree Duration: ");
                            int duration = int.Parse(Console.ReadLine());
                            Console.Write("Enter Degree Seats: ");
                            int seats = int.Parse(Console.ReadLine());
                            Console.Write("Enter How Many Subjects In Degree: ");
                            int num = int.Parse(Console.ReadLine());
                            List<Subject> temp = new List<Subject>();

                            for (int i = 0; i < num; i++)
                            {
                                Subject s = new Subject();
                                Subjects.Add(s);
                                temp.Add(s);
                            }

                            Degree degree = new Degree(name, duration, seats, temp);
                            Degrees.Add(degree);
                            Console.WriteLine("Your Degree Has Been Added");
                        }
                    }
                    else if (option == 3)
                    {
                        // merit calculation
                    }
                    else if (option == 5)
                    {
                        Console.WriteLine("Enter Degree Name: ");
                        string name = Console.ReadLine();
                        bool flag = false;
                        foreach (Degree d in Degrees)
                        {
                            if (name == d.name)
                            {
                                int i = 0;
                                flag = true;
                                foreach (Student s in Students)
                                {
                                    if (s.degree == d)
                                    {
                                        Console.Write($"{i}. ");
                                        s.showStudent();
                                        i++;
                                    }
                                }
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine("Degree Not Found!");
                        }
                        Console.ReadKey();
                    }
                    else if (option == 4)
                    {
                        int i = 0;
                        foreach (Student s in Students)
                        {
                            Console.Write($"{i}. ");
                            s.showStudent();
                            i++;
                        }
                        Console.ReadKey();
                    }
                    else if (option == 6)
                    {
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();
                        bool flag1 = false;
                        bool flag2 = false;
                        bool flag3 = false;
                        foreach (Student s in Students)
                        {
                            if (name == s.name)
                            {
                                flag1 = true;
                                Console.Write("Enter Subject Code: ");
                                int code = int.Parse(Console.ReadLine());

                                foreach (Subject sub in Subjects)
                                {
                                    if (sub.SubjectCode == code)
                                    {
                                        flag2 = true;
                                        foreach (Subject subj in s.RegisteredSubjects)
                                        {
                                            if (subj.SubjectCode == code)
                                            {
                                                flag3 = true;
                                                break;
                                            }
                                        }
                                        if (flag3)
                                        {
                                            Console.WriteLine($"{s.name} is already registered in {sub.SubjectCode}");
                                        }
                                        else
                                        {
                                            s.RegisteredSubjects.Add(sub);
                                            Console.WriteLine("Subject is Added");
                                        }
                                    }
                                }

                            }
                        }
                        if (!flag1)
                        {
                            Console.WriteLine("Student Doesn't Exist!");
                        }
                        else if (!flag2)
                        {
                            Console.WriteLine("Subject Doesn't Exist!");
                        }
                        Console.ReadKey();
                    }
                    else if (option == 7)
                    {
                        float sum = 0;
                        foreach (Student s in Students)
                        {
                            sum += s.CalculateFees();
                        }
                        Console.WriteLine($"Total Fees: {sum}");
                        Console.ReadKey();
                    }
                    else if (option == 8)
                    {
                        CurrentState = "Exit";
                    }

                }
            }
        }
        static int MainOption()
        {
            int option = 0;
            while (option < 1 || option > 8)
            {
                Console.Clear();
                Console.WriteLine("Select an Option");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Degree Program");
                Console.WriteLine("3. Generate Merit List");
                Console.WriteLine("4. View Registered Students");
                Console.WriteLine("5. View Students of a Specific Program");
                Console.WriteLine("6. Register Subjects for a Specific Student");
                Console.WriteLine("7. Calculate Fees For All Registerd Students");
                Console.WriteLine("8. Exit");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }
            return option;
        }
    }
}
