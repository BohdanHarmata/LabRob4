using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Project2
{
    class Sword : B
    {
        private int _sword;
        public Sword (int sword, int damage, int protection, int mDamage) : base (damage, protection, mDamage)
        {
            this._sword = sword;
            base._damage = damage;
            base._Protection = protection;
            base._mDamage = mDamage;
        }
        public int DamageWithSword(int damage, int sword)
        {
            int damageWithSword = damage + sword;
            return damageWithSword;
        }
        public void OutSwordDamage()
        {
            Debug.WriteLine($"Damage with sword {DamageWithSword(_damage, _sword)}");
        }
    }
}
