using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        public int count =0;
        public double balance ;
        public string[] type = new string[100];
        public double[] money = new double[100];

        public ATM(double paisa)
        {
            balance = paisa;
        }

        public void deposit(double amount)
        {
            balance += amount;
            type[count] = "Deposit";
            money[count] = amount;
            count += 1;
        }
        public void withdraw(double amount)
        { if(balance >= amount){ balance -= amount; type[count] = "Withdraw"; money[count] = amount;count += 1; }; }

        public double check_balance()
        {
            return balance;
        }
        
        public void transaction_History()
        {
            Console.Clear();
            Console.WriteLine("================ Transaction History =======================");
            for ( int i=0; i<count; i++)
            {
                Console.WriteLine("Transaction Type: {0}\nTransaction Amount: {1}\n\n", type[i], money[i]);
            }
        }


    }
}
