using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    internal class Member
    {
        public string name;
        public int ID;
        public int numBook;
        public float Money;
        public float amountSpent = 10.0F;
        public List<Book> books = new List<Book> ();

        public Member(string name, int ID, float Money)
        {
            this.name = name;
            this.ID = ID;
            this.Money = Money;
        }

        public void ShowMember()
        {
            Console.WriteLine($"Name: {name}\nID: {ID},\nBook Bought: {numBook},\nMoney In Bank: {Money}\nAmount Spent: {amountSpent}");
            Console.ReadKey();
        }

        public void PurchaseBook(Book b, int sales,int quantity)
        {
            if(Money > b.Price*quantity)
            {
                Money -= b.Price*quantity;
                books.Add( b );
                amountSpent += b.Price * quantity;
                sales += quantity;
            }
            else { Console.WriteLine("Insufficient Money!"); }
        }
    }
}
