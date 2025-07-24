using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paisa = -1;
            while (paisa <= 0)
            {
                Console.WriteLine("Enter Initial Balance: ");
                paisa = double.Parse(Console.ReadLine());
            }
                ATM s1 = new ATM(paisa);

            while (true)
            {
                Console.Clear();
                int option = 0;
                while (option < 1 || option > 4)
                {
                    Console.WriteLine("Please Choose and Option");
                    Console.WriteLine("1. Deposit Money");
                    Console.WriteLine("2. Withdraw Money");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. View Transaction History");
                    Console.WriteLine("\nYour Option: ");
                    option = int.Parse(Console.ReadLine());
                }

                if (option == 1)
                {
                    Console.WriteLine("Enter Amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    s1.deposit(amount);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter Amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    if (s1.balance >= amount)
                    {
                        s1.withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine("Your Balace is less than {0}!", amount);
                        Console.ReadKey();
                    }
                }
                else if (option == 3) 
                {
                    Console.WriteLine("Balance: {0}", s1.balance);
                    Console.ReadKey();
                }
                else if(option == 4)
                {
                    s1.transaction_History();
                    Console.ReadKey();
                }
            }
        }
    }
}
