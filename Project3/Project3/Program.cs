using System;
using System.Diagnostics;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose submenu : Enemy, Ally, Hero");
            string n = Console.ReadLine();
            if (n == "Enemy")
            {
                Enemy myEnemy = new Enemy("Goblin", 5, 30, 6, 0, 10);
                myEnemy.OutEnemy();
                Console.ReadKey();
            }
            else if (n == "Ally")
            {
                Ally myAlly = new Ally("Sourcer", 12, 3, 4, 20, 20, 1);
                myAlly.OutAlly();
                Console.ReadKey();
            }
            else if (n == "Hero")
            {
                Hero myHero = new Hero("Warrior", 20, 5, 20, 15, 2, 0, 2);
                myHero.OutHero();
                Console.ReadKey();
            }
        }
    }
}
