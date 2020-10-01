using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Project3
{
    class Enemy : Unit
    {
        public Enemy(string Name, int Health, int Damage, int Protection , int MagicDamage, int MagicProtection)
        {
            base._Name = Name;
            base._Health = Health;
            base._Damage = Damage;
            base._Protection = Protection;
            base._MagicDamage = MagicDamage;
            base._MagicProtection = MagicProtection;
        }
        public void OutEnemy()
        {
            Debug.WriteLine($"Name of enemy: {_Name}");
            Debug.WriteLine($"Health of enemy: {_Health}");
            Debug.WriteLine($"Damage of enemy: {_Damage}");
            Debug.WriteLine($"Defence of enemy: {_Protection}");
            Debug.WriteLine($"Magic damage of enemy: {_MagicDamage}");
            Debug.WriteLine($"Magic defence of enemy: {_MagicProtection}");
        }
    }
}
