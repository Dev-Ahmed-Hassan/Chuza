using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    internal class Book
    {
        public string title;
        public string authors;
        public string publisher;
        public string ISBN;
        public int stock;
        public int numAuthor;
        public float Price = 100;


        public Book(string title, string authors, string publisher, string iSBN, int stock, int numAuthor)
        {
            this.title = title;
            this.authors = authors;
            this.publisher = publisher;
            ISBN = iSBN;
            this.stock = stock;
            this.numAuthor = numAuthor;
        }

        public void updateStock(int n)
        {
            this.stock = n;
        }

        public void showBook()
        {
            Console.WriteLine($"Title: {title}\nAuthours: {authors}\nPublisher: {publisher}\nISBN: {ISBN}\nStock: {stock}");
        }
      

        
    }
}
