using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.Interfaces;
using _2DGameLib.Weapons;

namespace _2DGameLib.WeaponsFactory
{
    public class DefenseWeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(WeaponType type)
        {
            if (type == WeaponType.Ranged) return new CrossBow();
            if (type == WeaponType.Melee) return new Dagger();

            throw new ArgumentException($"DefenseWeaponFactory - no class available for weapon type {type}");
        }
    }
}
