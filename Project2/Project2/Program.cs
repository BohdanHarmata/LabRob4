using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Sword staff or nothing");
            string n = Console.ReadLine();
            if (n == "nothing")
            {
                A myA = new A(123, 100, 144);
                B myB = (B) myA;
                myB.Out();
                myA.Output();
                Console.ReadKey();
            }
            else if (n == "Staff")
            {
                MagicStaff myMagicStaff = new MagicStaff(12, 123, 100, 144);
                myMagicStaff.OutpuMDamage();
                Console.ReadKey();
            }
            else if (n == "Sword")
            {
                Sword mySword = new Sword(14, 123, 100, 144);
                mySword.OutSwordDamage();
                Console.ReadKey();
            }
        }
    }
}
