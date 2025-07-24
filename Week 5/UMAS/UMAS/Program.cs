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
            string currentState = "MainMenu";
            while (currentState != "Exit")
            {
                while (currentState == "MainMenu")
                {
                    Console.Clear();
                    int option = ConsoleUtility.menu();
                    if (option == 1) { currentState = "AddS"; }
                    else if (option == 2) { currentState = "AddD"; }
                    else if (option == 3) { currentState = "Merit"; }
                    else if (option == 4) { currentState = "ViewRS"; }
                    else if (option == 5) { currentState = "ViewSP"; }
                    else if (option == 7) { currentState = "Calculate Fees"; }
                    else if (option == 8) { currentState = "Exit"; }
                }
                while (currentState == "AddS")
                {
                    StudentBL s = StudentUI.AddStudent();
                    if (s != null)
                    {
                        StudentDL.AddStudent(s);
                    }
                    else
                    {
                        ConsoleUtility.ReadKey();
                    }
                    currentState = "MainMenu";
                }
                while (currentState == "AddD")
                {
                    DegreeBL d = DegreeUI.AddDegree();
                    if(d != null)
                    {
                        DegreeDL.AddDegree(d);
                    }
                    else
                    {
                        ConsoleUtility.ReadKey();
                    }
                    currentState = "MainMenu";
                }
                while (currentState == "Merit")
                {
                    StudentUI.ShowSorrow();
                    ConsoleUtility.ReadKey();
                    currentState = "MainMenu";
                }
                while (currentState == "ViewRS")
                {
                    StudentUI.ShowStudent(StudentDL.ShowStudent());
                    ConsoleUtility.ReadKey();
                    currentState = "MainMenu";
                }
                while(currentState == "ViewSP")
                {
                    StudentUI.ShowStudent(StudentDL.stuDeg(StudentUI.getdeg()));
                    currentState = "MainMenu";
                }
                while (currentState == "Calculate Fees")
                {
                    StudentUI.ShowSorrow();
                    ConsoleUtility.ReadKey();
                    currentState = "MainMenu";
                }

            }
        }
    }
}
