using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UMAS
{
    internal class DegreeUI
    {
        static public DegreeBL AddDegree()
        {
            
            Console.Write("Enter Degree Name: ");
            string name = Console.ReadLine();
            if (DegreeDL.CheckDegreeByName(name))
            {
                Console.WriteLine("Degree Already Exists!");
                return null;
            }
            else{
                Console.Write("Enter Degree Duration: ");
                int duration = int.Parse(Console.ReadLine());
                Console.Write("Enter Degree Seats: ");
                int seats = int.Parse(Console.ReadLine());
                Console.Write("Enter How Many Subjects In Degree: ");
                int num = int.Parse(Console.ReadLine());
                DegreeBL degree = new DegreeBL(name, duration, seats, num);
                for (int i = 0;i< num; i++)
                {
                    bool found = true;
                    int code = 0;
                    while (found)
                    {
                        Console.WriteLine("Enter Code: ");
                        code = int.Parse(Console.ReadLine());
                        found = SubjectDL.CheckSubjectByCode(code);
                        Console.WriteLine("Subject Already Exists!");
                    }
                    Console.WriteLine("Enter Type: ");
                    string type = (Console.ReadLine());
                    Console.WriteLine("Enter Credit Hours: ");
                    int CH = int.Parse(Console.ReadLine());
                    Console.WriteLine("Fees: ");
                    int Fee = int.Parse(Console.ReadLine());

                    SubjectBL sub = new SubjectBL(code, type, CH, Fee);
                    degree.AddSubject(sub);
                }
                return degree;
            }
        }
    }
}
