using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.Interfaces;
using _2DGameLib.Weapons;

namespace _2DGameLib.WeaponsFactory
{
    public class AttackWeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(WeaponType type)
        {
            if (type == WeaponType.Ranged) return new Sword();
            if (type == WeaponType.Melee) return new Shield();

            throw new ArgumentException($"AttackWeaponFactory - no class available for weapon type {type}");
        }
    }
}
