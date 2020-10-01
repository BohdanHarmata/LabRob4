using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Project2
{
    class MagicStaff : B
    {
        private int _staffDamage;
        public MagicStaff(int staffDamage, int damage, int protection, int mDamage) : base (damage,protection, mDamage)
        {
            this._staffDamage = staffDamage;
            base._damage = damage;
            base._Protection = protection;
            base._mDamage = mDamage;
        }
        public int Magicdamagewithstaff (int mDamage, int stafDamage)
        {
            int totalMDamage = mDamage + stafDamage;
            return totalMDamage;
        }
        public void OutpuMDamage()
        {
            Debug.WriteLine($"Magic damage with magic staff {Magicdamagewithstaff(_mDamage, _staffDamage)}");
        }
    }
}
