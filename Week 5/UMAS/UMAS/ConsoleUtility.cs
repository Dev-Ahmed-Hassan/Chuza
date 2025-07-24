using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class ConsoleUtility
    {
        static public void ReadKey()
        {
            Console.ReadKey();
        }
        public static int menu()
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
