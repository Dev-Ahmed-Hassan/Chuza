using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                calculator s1 = new calculator();
            int option = 0;
            double answer = 0.0;
            bool flag = false;
            while(option < 1 || option > 4)
                {Console.WriteLine("Enter Option: ");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter First Num: ");
            s1.firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Num: ");
            s1.secondNum = double.Parse(Console.ReadLine());

            if (option == 1)
            {
                answer = s1.Addition(s1.firstNum, s1.secondNum);
            }
            else if (option == 2)
            {
                answer = s1.Subtraction(s1.firstNum, s1.secondNum);
            }
            else if (option == 3)
            {
                answer = s1.Product(s1.firstNum, s1.secondNum);
            }
            else if(option == 4)
            {
                answer = s1.Division(s1.firstNum, s1.secondNum);
                if (double.IsNaN(answer))
                {
                    Console.WriteLine("Can't Divide by Zero!");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine(answer);
            }
                Console.ReadKey();
            
        }
    }}
}
