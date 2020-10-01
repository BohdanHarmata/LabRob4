using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Project3
{
    class Hero : Unit
    {
        public Hero(string Name, int Health, int Mana, int Damage, int Protection, int MagicDamage, int MagicProtection, int Expirience)
        {
            base._Name = Name;
            base._Health = Health;
            base._Mana = Mana;
            base._Damage = Damage;
            base._Protection = Protection;
            base._MagicDamage = MagicDamage;
            base._MagicProtection = MagicProtection;
            base._Expirience = Expirience;
        }
        public void OutHero()
        {
            Debug.WriteLine($"Name of hero: {_Name}");
            Debug.WriteLine($"Health of hero: {_Health}");
            Debug.WriteLine($"Mana of hero: {_Mana}");
            Debug.WriteLine($"Damage of hero: {_Damage}");
            Debug.WriteLine($"Defence of hero: {_Protection}");
            Debug.WriteLine($"Magic damage of hero: {_MagicDamage}");
            Debug.WriteLine($"Magic defence of hero: {_MagicProtection}");
            Debug.WriteLine($"Level of hero: {_Expirience}");
        }
    }
}
