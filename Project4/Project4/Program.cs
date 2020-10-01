using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ключ на пробну або платну версію");
            ApplicationLicense myApp = new ApplicationLicense(Console.ReadLine(), Console.ReadLine());
            myApp.Out();
            Console.ReadKey();
        }
    }
}
