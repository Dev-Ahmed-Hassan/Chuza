using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA1
{
    internal class Transaction
    {
            public int TransactionId;
            public string ProductName;
            public double Amount;
            public string date;
            public string time;

            public Transaction()
            {

            }

            public Transaction(Transaction transaction)
            {
                TransactionId = transaction.TransactionId;
                ProductName = transaction.ProductName;
                Amount = transaction.Amount;
                date = transaction.date;
                time = transaction.time;
            }


        }
}
