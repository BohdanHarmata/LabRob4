using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data;


namespace Project1
{
    class Person1
    {
        protected int _Hp;
        protected int _Mana;
        public Person1(int Hp, int Mana)
        {
            this._Hp = Hp;
            this._Mana = Mana;
        }
        public void Person()
        {
            Console.WriteLine($"Health Bar int: {_Hp}");
            Console.WriteLine($"Mana int: {_Mana}");
        }
    }
}
