using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Project2
{
    class A : B
    {
        private int _totalDamage;
        public A (int damage, int protection, int mDamage) : base (damage, protection, mDamage)
        {
            base._damage = damage;
            base._Protection = protection;
            base._mDamage = mDamage;
        }
        public int Calculate(int damage, int protection)
        {
            int totalDamage = damage - (protection - 100 / 20);
            return totalDamage;
        }
        public int mDamage (int mDamage, int protection)
        {
            int totaldamage = mDamage - protection / 100;
            return totaldamage;
        }
        public void Output()
        {
            Debug.WriteLine($"Total Damage {Calculate(_damage, _Protection)}");
            Debug.WriteLine($"Total magic damage {mDamage(_mDamage, _Protection)}");
        }
    }
}
