using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data;


namespace Project1
{
    class Person2 : Person1
    {
        private int _Exp;
        public Person2 (int Hp, int Mana, int Exp) : base(Hp, Mana)
        {
            base._Hp = Hp;
            base._Mana = Mana;
            this._Exp = Exp;
        }

        public void Out() 
        {
            base.Person();
            Console.WriteLine($"Expirience int: {_Exp}");
        }


    }
}
