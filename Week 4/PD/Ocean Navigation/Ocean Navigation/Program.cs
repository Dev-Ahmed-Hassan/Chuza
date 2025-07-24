using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CurrentState = "MainMenu";

            List<ship> ships = new List<ship>();

            while(CurrentState != "Exit")
            {
                while (CurrentState == "MainMenu")
                {
                    int option = MainOption();
                    if (option == 1) { CurrentState = "Add"; }
                    else if (option == 2) { CurrentState = "VP"; }
                    else if (option == 3) { CurrentState = "VS"; }
                    else if (option == 4) { CurrentState = "CP"; }
                    else if (option == 5) { CurrentState = "Exit"; }
                }
                while (CurrentState == "Add")
                {
                    Console.Write("Enter Ship Number: ");
                    string number = Console.ReadLine();
                    Console.WriteLine("\nEnter Ship Latitude: ");
                    Console.Write("Enter Latitude's Degree: ");
                    int latdeg = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Minute: ");
                    float latmin = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Direction: ");
                    char latdir = Console.ReadLine()[0];
                    Console.WriteLine("\nEnter Ship Longitude: ");
                    Console.Write("Enter Longitude's Degree: ");
                    int londeg = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Minute: ");
                    float lonmin = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Direction: ");
                    char londir = Console.ReadLine()[0];
                    angle Latitude = new angle(latdeg,latmin, latdir);
                    angle Longitude = new angle(latdeg, latmin, latdir);
                    ship s = new ship(number, Latitude, Longitude);
                    ships.Add(s);
                    Console.WriteLine("Your Ship has been added successfully!!");
                    Console.ReadKey();
                    CurrentState = "MainMenu";
                }
                while (CurrentState == "VP")
                {
                    Console.Write("Enter Ship Serial Number to find its position: ");
                    string serial = Console.ReadLine();
                    bool flag = false;
                    foreach(ship n in ships)
                    {
                        if (n.ShipNumber == serial)
                        {
                            Console.WriteLine(n.PrintPosition());
                            flag = true;
                            break;
                        }
                    }
                    if(!flag)
                    {
                        Console.WriteLine("Ship Not Found Error!!");
                    }
                    Console.ReadKey();
                    CurrentState = "MainMenu";
                }
                while (CurrentState == "VS")
                {
                    Console.Write("Enter the ship latitude: ");
                    string lat = Console.ReadLine();
                    Console.Write("Enter the ship longitude: ");
                    string lon = Console.ReadLine();
                    bool flag = false;
                    foreach(ship n in ships)
                    {
                        if (n.Latitude.ShowAngle() == lat && n.Longitude.ShowAngle() == lon)
                        {
                            Console.WriteLine($"Ship’s serial number is : {n.ShowSerial()}");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    { Console.WriteLine("Ship Not Found Error!!"); }

                    Console.ReadKey();
                    CurrentState = "MainMenu";
                }
                while (CurrentState == "CP")
                {
                    Console.Write("Enter Ship’s serial number whose position you want to change: ");
                    string serial = Console.ReadLine();
                    
                    Console.WriteLine("\nEnter Ship Latitude: ");
                    Console.Write("Enter Latitude's Degree: ");
                    int latdeg = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Minute: ");
                    float latmin = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Direction: ");
                    char latdir = Console.ReadLine()[0];
                    Console.WriteLine("\nEnter Ship Longitude: ");
                    Console.Write("Enter Longitude's Degree: ");
                    int londeg = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Minute: ");
                    float lonmin = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Direction: ");
                    char londir = Console.ReadLine()[0];
                    
                    
                        bool flag = false;
                    foreach(ship n in ships)
                    {
                        if (n.ShipNumber == serial)
                        {
                            n.Latitude.AlterAngle(latdeg, latmin, latdir);
                            n.Longitude.AlterAngle(londeg, lonmin, londir);
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        Console.WriteLine("Your Ship has been added successfully!!");
                    else Console.WriteLine("Ship Not Found Error!!!");
                    Console.ReadKey();
                    CurrentState = "MainMenu";
                }
            }
        }
        static int MainOption()
        {
            int option = 0;
            while (option < 1 || option > 5)
            {
                Console.Clear();
                Console.WriteLine("Please Choose an Option: ");
                Console.WriteLine("1. Add Ship");
                Console.WriteLine("2. View Ship Position");
                Console.WriteLine("3. View Ship Serial Number");
                Console.WriteLine("4. Change Ship Position");
                Console.WriteLine("5. Exit");
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
            }
            return option;
        }
    }
}
