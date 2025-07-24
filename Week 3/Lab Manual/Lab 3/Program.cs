using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clockType empty_time = new clockType();

            Console.Write("Empty time: ");
            empty_time.printTime();

            clockType hour_time = new clockType(8);

            Console.Write("Hour time: ");
            hour_time.printTime();

            clockType minute_time = new clockType(8, 10);

            Console.Write("Minute time: ");
            minute_time.printTime();

            clockType full_time = new clockType(8, 10, 10);

            Console.Write("Full time: ");
            full_time.printTime();

            full_time.incrementSecond();

            Console.Write("Full time (Increment Second): ");
            full_time.printTime();

            full_time.incrementhours();

            Console.Write("Full time (Increment hours): ");
            full_time.printTime();

            full_time.incrementminutes();

            Console.Write("Full time (Increment Mintues): "); 
            full_time.printTime();

            bool flag = full_time.isEqual(9, 11, 11);

            Console.WriteLine("Flag: " + flag);

            clockType cmp = new clockType(10, 12, 1);

            flag = full_time.isEqual(cmp); 
            Console.WriteLine("Object Flag: " + flag);
        }
    }
}
