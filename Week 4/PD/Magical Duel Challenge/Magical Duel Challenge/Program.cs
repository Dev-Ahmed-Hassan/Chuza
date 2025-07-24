using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Duel_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentState = "MainMenu";
            List<Player> p = new List<Player>();
            while(currentState != "Exit")
            {
                int option = MainOpt();
                if (option == 1)
                {
                    Console.Write("Enter Player Name: ");
                    string name = Console.ReadLine();

                    foreach (Player p2 in p)
                    {
                        if (p2.name == name)
                        {
                            Console.WriteLine("Player Already Exists!");
                            Console.ReadKey();
                            break;
                        }
                    }
                    Console.Write("Enter Player Health: ");
                    float health = float.Parse(Console.ReadLine());

                    Console.Write("Enter Player Energy: ");
                    float energy = float.Parse(Console.ReadLine());

                    Console.Write("Enter Player Armor: ");
                    float armor = float.Parse(Console.ReadLine());

                    Player pl = new Player(name, health, energy, armor);
                    p.Add(pl);
                    Console.WriteLine("Player has succfully been added!");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.Write("Enter Player Name: ");
                    string name = Console.ReadLine();
                    Player pal = new Player("abc", 1, 1, 1);
                    bool flag = false;
                    foreach (Player p2 in p)
                    {
                        if (p2.name == name)
                        {
                            flag = true;
                            pal = p2;
                        }

                    }

                    if (flag)
                    {
                        Console.Write("Enetr Skill Name: ");
                        string sname = Console.ReadLine();

                        Console.Write("Enter Skill Damage: ");
                        float damage = float.Parse(Console.ReadLine());

                        Console.Write("Enter Skill Penetration: ");
                        float penetration = float.Parse(Console.ReadLine());

                        Console.Write("Enter Skill Heal: ");
                        float heal = float.Parse(Console.ReadLine());

                        Console.Write("Enter Skill Cost: ");
                        float cost = float.Parse(Console.ReadLine());

                        Console.Write("Enter Skill Description: ");
                        string description = Console.ReadLine();

                        Stats s = new Stats(damage, penetration, heal, cost, description);
                        s.name = sname;
                        pal.learnSkill(s);

                        Console.WriteLine("Your Skill has been Added!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No Player with this name exists!");
                        Console.ReadKey();
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter Attacking Player Name: ");
                    string atname = Console.ReadLine();
                    Console.Write("Enter Enemy Name: ");
                    string emname = Console.ReadLine();
                    bool flag1 = false;
                    bool flag2 = false;
                    bool flag3 = false;
                    Player at = new Player("abc", 1, 1, 1);
                    Player em = new Player("abc", 1, 1, 1);
                    if (atname == emname) { flag3 = true; }
                    foreach (Player p2 in p)
                    {

                        if (p2.name == atname)
                        {
                            flag1 = true;
                            at = p2;
                        }
                        if (p2.name == emname)
                        {
                            flag2 = true;
                            em = p2;
                        }
                        if (flag1 && flag2)
                        {
                            Console.WriteLine(at.Attack(em));
                        }
                    }
                    if (!flag1)
                    {
                        Console.WriteLine($"There is no Player with the name of {atname}");
                    }
                    if (!flag2)
                    {
                        Console.WriteLine($"There is no Player with the name of {emname}");
                    }
                    if (flag3)
                    {
                        Console.WriteLine($"Attacker Name and Enemy Names can't be the same!!");
                    }
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Console.Write("Enter Player Name: ");
                    string name = Console.ReadLine();
                    bool flag = false;
                    foreach(Player p2 in p)
                    {
                        if (p2.name == name)
                        {
                            p2.showInfo();
                            flag = true;
                        }
                    }
                    if(!flag)
                    {
                        Console.WriteLine("No Player with this name Exists!");
                    }
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    currentState = "Exit";
                }
            }

        }
        static int MainOpt()
        {
            int option = 0;
            while (option < 1 || option > 5)
            {
                Console.Clear();
                Console.WriteLine("Choose and Option: ");
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Learn Skill");
                Console.WriteLine("3. Attack");
                Console.WriteLine("4. Show Player Info");
                Console.WriteLine("5. Exit");
                option = int.Parse(Console.ReadLine());
            }
            return option;
        }
    }
}
