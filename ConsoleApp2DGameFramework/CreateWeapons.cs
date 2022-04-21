using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib;
using _2DGameLib.Interfaces;
using _2DGameLib.WeaponsFactory;
using Trace = _2DGameLib.Trace;

namespace ConsoleApp2DGameFramework
{
    public class CreateWeapons
    {
        public static IWeapon GetWeaponType(IWeaponFactory factory)
        {
            Random random = new Random();
            int rand = random.Next(2);
            if (rand is 0)
            {
                IWeapon meleeWeapon = factory.CreateWeapon(WeaponType.Melee);
                return meleeWeapon;
            }
            else
            {
                IWeapon rangeWeapon = factory.CreateWeapon(WeaponType.Ranged);
                return rangeWeapon;
            }
        }

        public static IWeapon GetAttackWeapon(Creature main)
        {
            Trace.ApplicationLog(TraceEventType.Information, $"{main.Name} has an attack weapon.");
            return GetWeaponType(new AttackWeaponFactory());
        }

        public static IWeapon GetDefenseWeapon(Creature enemy)
        {
            Console.WriteLine();
            Trace.ApplicationLog(TraceEventType.Information, $"{enemy.Name} has a defense weapon.");
            return GetWeaponType(new DefenseWeaponFactory());
        }
    }
}
