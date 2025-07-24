using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class SubjectUI
    {
        static SubjectBL AddSubject()
        {
            Console.WriteLine("Enter Code: ");
            int code = int.Parse(Console.ReadLine());
            bool found = SubjectDL.CheckSubjectByCode(code);
            if (found)
            {
                Console.WriteLine("Subject Already Exists!");
                return null;
            }
            else
            {
                Console.WriteLine("Enter Type: ");
                string type = (Console.ReadLine());
                Console.WriteLine("Enter Credit Hours: ");
                int CH = int.Parse(Console.ReadLine());
                Console.WriteLine("Fees: ");
                int Fee = int.Parse(Console.ReadLine());

                SubjectBL sub = new SubjectBL(code,type, CH, Fee);
                return sub;
            }
        }
    }
}
