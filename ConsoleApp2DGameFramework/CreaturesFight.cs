using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib;
using _2DGameLib.Interfaces;
using Trace = _2DGameLib.Trace;

namespace ConsoleApp2DGameFramework
{
    public class CreaturesFight
    {
        public static void Fight(Creature main, Creature enemy)
        {
            while (main.IsDead() != true && enemy.IsDead() != true)
            {
                main.Attack(enemy);
                Console.WriteLine($"{main.Name} hit {enemy.Name}");
                Console.WriteLine("-------------------------------------------");
                if (enemy.IsDead() != true)
                {
                    enemy.Attack(main);
                    Console.WriteLine($"{enemy.Name} hit {main.Name}");
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    break;
                }
            }
            if (main.IsWinner() || enemy.IsWinner())
            {

            }
        }
    }
}