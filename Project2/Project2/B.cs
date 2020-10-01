using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Project2
{
    class B
    {
        protected int _damage;
        protected int _Protection;
        protected int _mDamage;
        public B (int damage, int protection, int mDamage)
        {
            this._damage = damage;
            this._Protection = protection;
            this._mDamage = mDamage;
        }
        public void Out ()
        {
            Debug.WriteLine($"Magic damage {_mDamage}");
            Debug.WriteLine($"Damage: {_damage}");
            Debug.WriteLine($"Protection {_Protection}");
        }
    }
}
