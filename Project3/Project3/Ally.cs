using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Project3
{
    class Ally : Unit
    {
        public Ally(string Name, int Health, int Damage, int Protection, int MagicDamage, int MagicProtection, int Expirience) 
        {
            base._Name = Name;
            base._Health = Health;
            base._Damage = Damage;
            base._Protection = Protection;
            base._MagicDamage = MagicDamage;
            base._MagicProtection = MagicProtection;
            base._Expirience = Expirience;
        }
        public void OutAlly()
        {
            Debug.WriteLine($"Name of ally: {_Name}");
            Debug.WriteLine($"Health of ally: {_Health}");
            Debug.WriteLine($"Damage of ally: {_Damage}");
            Debug.WriteLine($"Defence of ally: {_Protection}");
            Debug.WriteLine($"Magic damage of ally: {_MagicDamage}");
            Debug.WriteLine($"Magic defence of ally: {_MagicProtection}");
            Debug.WriteLine($"Level of ally: {_Expirience}");
        }

    }
}
