using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class Subject
    {
        public int SubjectCode;
        public string SubjectType;
        public int SubjectCredit;
        public float SubjectFees;
        public Subject()
        {
                Console.Write("Enter Subject Code: ");
                SubjectCode = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject Type: ");
                SubjectType = Console.ReadLine();
                Console.Write("Enter Subject Credit: ");
                SubjectCredit = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject Fees: ");
                SubjectFees = float.Parse(Console.ReadLine());
        }
    }

}
