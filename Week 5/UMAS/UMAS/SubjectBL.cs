using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class SubjectBL
    {
        public int SubjectCode;
        public string SubType;
        public int CreditHours;
        public int Fees;

        public SubjectBL(int Co, string ty, int hou, int fee)
        {
            SubjectCode = Co;   
            SubType = ty;
            CreditHours = hou;
            Fees = fee;
        }

        public SubjectBL()
        {
            Console.Write("Enter Subject Code: ");
            SubjectCode = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Type: ");
            SubType = Console.ReadLine();
            Console.Write("Enter Subject Credit: ");
            CreditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            Fees = int.Parse(Console.ReadLine());
        }



    }
}
