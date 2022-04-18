using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib;

namespace ConsoleApp2DGameFramework
{
    public class CreaturesFight
    {
        public static void Fight(Creature main, Creature enemy)
        {
            while (main.IsDead() != true && enemy.IsDead() != true)
            {
                main.Attack(enemy);
                if (enemy.IsDead() != true)
                {
                    enemy.Attack(main);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
