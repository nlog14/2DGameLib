using System;
using System.Diagnostics;
using _2DGameLib;
using _2DGameLib.Interfaces;
using _2DGameLib.WeaponsFactory;
using Trace = _2DGameLib.Trace;

namespace ConsoleApp2DGameFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            Position positionMain = new Position(5, 5);
            Creature main = new Creature("Amethyst", positionMain);
            IWeapon attackWeapon = CreateWeapons.GetAttackWeapon(main);
            main.attackItems.Add(attackWeapon);


            Position positionEnemy = new Position(5, 7);
            Creature enemy = new Creature("Vac", positionEnemy);
            IWeapon defenseWeapon = CreateWeapons.GetDefenseWeapon(enemy);
            enemy.defenceItems.Add(defenseWeapon);

            CreaturesFight.Fight(main, enemy);
        }
    }
}