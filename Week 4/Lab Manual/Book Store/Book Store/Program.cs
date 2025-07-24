using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sales = 0;  
            string CurrentState = "MainMenu";

            List<Book> b = new List<Book>();
            List<Member> m = new List<Member>();


            while(CurrentState != "Exit")
            {
                while(CurrentState == "MainMenu")
                {
                    int option = MainOpt();
                    if (option == 1)
                    {
                        CurrentState = "Owner";
                    }
                    else if (option == 2)
                    {
                        CurrentState = "Customer";
                    }
                    else if (option == 3)
                    {
                        CurrentState = "Exit";
                    }
                }

                while(CurrentState == "Owner")
                {
                    int option = OwnMenu();
                    if(option == 1)
                    {
                        AddBook(b);
                    }
                    else if (option == 2)
                    {
                        Console.Write("Enter Book Name: ");
                        string name = Console.ReadLine();
                        bool flag = false;
                        foreach(Book n in b)
                        {
                            if (n.title == name)
                            {
                                Console.Write("Enter New Stock");
                                int newStock = int.Parse(Console.ReadLine());
                                n.updateStock(newStock);
                                flag = true;
                            }
                        }
                        if(!flag)
                        {
                            Console.WriteLine("Your Book is not found!");
                        }
                        Console.ReadKey();
                    }
                    else if(option == 3)
                    {
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Memeber ID: ");
                        int id = int.Parse(Console.ReadLine()) ;
                        Console.Write("Enter Money In Bank: ");
                        float money = float.Parse(Console.ReadLine());

                        Member mem = new Member(name, id, money);
                        m.Add(mem);
                        Console.WriteLine("You Member has been Added Successfully!");
                        Console.ReadKey();
                    }
                    else if (option == 4)
                    {
                        Console.WriteLine("Enter Member Name: ");
                        string name = Console.ReadLine();
                        bool flag = false;
                        foreach(Member n in m)
                        {
                            if(n.name == name)
                            {
                                n.ShowMember();
                                flag = true;
                            }
                        }
                        if(!flag)
                        {
                            Console.WriteLine("This Member is not found in the record!");
                        }
                        Console.ReadKey();
                    }    
                    else if(option == 5)
                    {
                        Console.Write("Enter Member Name: ");
                        string name = Console.ReadLine();
                        bool flag = false;
                        foreach(Member n in m)
                        {
                            if(n.name == name)
                            {
                                Console.Write("Enter Memeber ID: ");
                                int id = int.Parse(Console.ReadLine());
                                Console.Write("Enter Money In Bank: ");
                                float money = float.Parse(Console.ReadLine());
                                n.ID = id;
                                n.Money = money;
                                Console.WriteLine("Your Member has been Updated Successfully!");
                                flag = true;
                            }
                        }
                        if(!flag)
                        {
                            Console.WriteLine("No Member Found with this name.");
                        }
                        Console.ReadKey();
                        
                    }
                    else if(option == 6)
                    {
                        DisplayData(sales, m);
                    }
                    else if(option == 7)
                    {
                        CurrentState = "MainMenu";
                    }
                }
                while(CurrentState == "Customer")
                {
                    int option = CusOpt();
                    if (option == 1)
                    {
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        bool flag = false;
                       foreach(Book n in b)
                        {
                            if(n.title == title)
                            {
                                n.showBook();
                                flag = true;
                            }
                        }
                       if(!flag)
                        {
                            Console.WriteLine("Your Book Couldn't be Found!");
                        }
                        Console.ReadKey();
                    }
                    else if(option == 2)
                    {
                        Console.Write("Enter Book ISBN: ");
                        string isbn = Console.ReadLine();
                        bool flag = false;
                        foreach (Book n in b)
                        {
                            if (n.ISBN == isbn)
                            {
                                n.showBook();
                                flag = true;
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine("Your Book Couldn't be Found!");
                        }
                        Console.ReadKey();
                    }
                    else if(option == 3)
                    {
                        Console.Write("Enter Memeber Name: ");
                        string name = Console.ReadLine();
                        bool flag = false;
                        bool flag1 = false;
                        bool flag3 = true ;
                        Member member = new Member("",00, 0.0F);
                        foreach(Member mem in m)
                        {
                            if(mem.name == name)
                            {
                                member = mem;
                                flag1 = true;
                                break;
                            }
                        }
                        if(flag1)
                        {
                            Console.Write("Enter Book Title: ");
                            string title = Console.ReadLine();

                            foreach (Book n in b)
                            {
                                if (n.title == title)
                                {
                                    Console.WriteLine("Enter Quantity of Books: ");
                                    int quantity = int.Parse(Console.ReadLine());
                                    member.PurchaseBook(n,sales,quantity);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine("Your Book Couldn't be Found!");
                        }
                        if(!flag1)
                        {
                            Console.WriteLine("Your Member Can't be Found!");
                        }
                    }
                    if(option == 4)
                    {
                        CurrentState = "MainMenu";
                    }
                }
            }


        }

        static void DisplayData(int n, List<Member> m)
        {
            Console.WriteLine($"Books Sold: {n}\nTotal Members: {m.Count}\nTotal MemberShip Fee: {m.Count*10}");
            Console.ReadKey();
        }
        static void AddBook(List<Book> b)
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Number of Authors: ");
            int numAut = int.Parse(Console.ReadLine());
            Console.Write("Enter Authors: ");
            string author = Console.ReadLine();
            Console.Write("Enter Publisher: ");
            string publisher = Console.ReadLine();
            Console.Write("Enter ISBN: ");
            string ISBN = Console.ReadLine();
            Console.Write("Enter Stock: ");
            int stock = int.Parse(Console.ReadLine());

            Book book = new Book( title,  author, publisher,  ISBN,  stock, numAut);
            b.Add( book );
            Console.WriteLine("Your Book Has Been Added Successfuly!");
            Console.ReadKey();
        }

        static int CusOpt()
        {
            int option = 0;
            while (option < 1 || option > 4)
            {
                Console.Clear();
                Console.WriteLine("Choose Your Option: ");
                Console.WriteLine("1. Search Book By Title");
                Console.WriteLine("2. Search Book By ISBN");
                Console.WriteLine("3. Purchase Book");
                Console.WriteLine("4. Back");
                option = int.Parse(Console.ReadLine());
            }
            return option;
        }

        static int OwnMenu()
        {
            int option = 0;
            while (option < 1 || option > 7)
            {
                Console.Clear();
                Console.WriteLine("Choose Your Option: ");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Add Member");
                Console.WriteLine("4. Search Memeber");
                Console.WriteLine("5. Update Member");
                Console.WriteLine("6. Display Stats");
                Console.WriteLine("7. Back");
                option = int.Parse(Console.ReadLine());
            }
            return option;
        }
        static int MainOpt()
        {
            int option = 0;
            while (option < 1 || option > 3)
            {
                Console.Clear();
                Console.WriteLine("Choose Your User Type: ");
                Console.WriteLine("1. Shop Owner");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                option = int.Parse(Console.ReadLine());
            }
            return option;
        }
    }
}
