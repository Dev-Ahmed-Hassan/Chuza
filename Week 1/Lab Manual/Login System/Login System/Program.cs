using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;

namespace Login_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentState = "Menu";
            int activeUserIndex = -1;
            string activeUserName;
            string path = "data.txt";

            string[] userName = new string[100];
            string[] passwords = new string[100];
            string[] userType = new string[100];

            int userCount = read(path, userName, passwords, userType);

            while (currentState != "Exit")
            {
                int optionMain = 0;
                while (currentState == "Menu")
                { 
                    optionMain = menu(); 

                    if (optionMain == 1)
                    {
                        currentState = "In";
                    }
                    else if (optionMain == 2)
                    {
                        currentState = "Up";
                    }
                    else if (optionMain == 3)
                    {
                        currentState = "Exit";
                    }

                }

                if(currentState == "Up")
                {
                    bool match = false;
                    Console.Clear();
                    Console.WriteLine("================= SIGN UP =================");
                    Console.Write("Enter Your Email: ");
                    activeUserName = Console.ReadLine();
                    string pass = "";
                    if(CheckUser(userCount, activeUserName, userName, ref activeUserIndex))
                    {
                        activeUserName = "";
                        Console.WriteLine();
                        Console.WriteLine("Your UserName is already found!!");
                        Console.WriteLine("Try Signing in!");
                        Console.ReadKey();
                        currentState = "Menu";
                    }
                    else
                    {
                        while (!match)
                        {
                            Console.Write("Enter New Password: ");
                            pass = Console.ReadLine();
                            Console.Write("Confirm Your Password: ");
                            string conf = Console.ReadLine();

                            if (conf == pass)
                            {
                                match = true;
                            }
                            else
                            {
                                Console.WriteLine("Your Passwords do not Match!");
                            }
                        }

                        Console.WriteLine("Your Account Has Been Created");
                        userName[userCount] = activeUserName;
                        passwords[userCount] = pass;
                        userType[userCount] = "s";
                        userCount++;
                        save(path, userName, passwords, userType, userCount);
                        currentState = "Menu";
                    }
                }

                if (currentState == "In")
                {
                    Console.Clear();
                    Console.WriteLine("================= SIGN IN =================");
                    Console.Write("Enter Your Email: ");
                    activeUserName = Console.ReadLine();
                    string pass;
                    if (!CheckUser(userCount, activeUserName, userName, ref activeUserIndex))
                    {
                        activeUserName = "";
                        Console.WriteLine();
                        Console.WriteLine("Your UserName is not found!!");
                        Console.ReadKey();
                        currentState = "Menu";
                    }
                    else
                    {
                        Console.Write("Enter Your Password: ");
                        pass = Console.ReadLine();
                        int passCount = 0;
                        if(VerifyPass(activeUserIndex, passwords, pass))
                        {
                            Console.WriteLine("You have successfully signed in as {0}", activeUserName); // Just a placeholder. If I want to extend it, then I will change the current state to a relative user menu determined by the sign in function.
                            Console.Write("Press Any Key to Return to main menu: ");
                            Console.ReadKey();
                            currentState = "Menu";
                        }
                        else
                        {
                            if(passCount < 3)
                            {
                                Console.WriteLine("Your password is incorrect write it again");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("You have tried too many times!");
                                Console.ReadKey();
                                currentState = "Menu";
                            }
                        }

                    }
                }
            }
        }

        static void save(string path, string[] userName, string[] password, string[] userType, int count)
        {
            StreamWriter sw = new StreamWriter(path);
            string line = "";
            for (int i = 0; i < count; i++)
            {
                line += userName[i];
                line += ",";
                line += password[i];
                line += ",";
                line += userType[i];
                sw.WriteLine(line);
                line = "";
            }
            sw.Close();
        }

        static bool VerifyPass(int idx, string[] password, string pass)
        {
            bool flag = false;
            if(pass == password[idx])
            {
                flag = true;
            }
            return flag;
        }

        static bool CheckUser(int count, string user, string[] userName, ref int active)
        {
            bool flag=  false;
            for(int i=0; i<count; i++)
            {
                if (user == userName[i])
                {
                    flag = true;
                    active = i;
                    break;
                }
            }
            return flag;
        }

        static int read(string path, string[] userName, string[] password, string[] userType)
        {
            int userCount = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream) // Read until the end of the file
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] parts = line.Split(','); // Split the line by commas

                        // Check if all three parts are available
                        if (parts.Length >= 3)
                        {
                            userName[userCount] = parts[0];
                            password[userCount] = parts[1];
                            userType[userCount] = parts[2];
                            userCount++;
                        }
                        else
                        {
                            Console.WriteLine("Warning: Line in data file has missing entries.");
                        }
                    }
                }
            }
            return userCount;
        }

        static int menu()
        {
            int option = 0;
            while (option <= 0 || option > 3)
            {
                Console.Clear();
                Console.WriteLine("Please Choose an option");
                Console.WriteLine("1. SignIn");
                Console.WriteLine("2. SignUp");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.Write("Enter your Option: ");
                option = int.Parse(Console.ReadLine());

                if(option <= 0 || option > 3)
                {
                    Console.WriteLine("Please Enter a valid option");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
            return option;
        }
    }
}




