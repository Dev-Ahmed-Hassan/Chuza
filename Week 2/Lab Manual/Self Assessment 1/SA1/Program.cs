using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction s1 = new Transaction();
            Console.Write("TransactionID: ");
            s1.TransactionId = int.Parse(Console.ReadLine());
            Console.Write("Product Name: ");
            s1.ProductName = Console.ReadLine();
            Console.Write("Amount: ");
            s1.Amount = int.Parse(Console.ReadLine());
            Console.Write("Date: ");
            s1.date = Console.ReadLine();
            Console.Write("Time: ");
            s1.time = Console.ReadLine();

            Transaction s2 = new Transaction(s1);

            s1.time = "12:30";
            s1.date = "12/04";

            Console.WriteLine("s1 Time: {0}  \ns1 date = {1} \ns2 Time: {2}  \ns2 date: {3}", s1.time, s1.date,s2.time,s2.date);
            Console.ReadKey();

        }
    }

    
}
