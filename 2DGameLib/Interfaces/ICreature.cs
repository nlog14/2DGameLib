using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib.Interfaces
{
    public interface ICreature
    {
        public void Attack(Creature enemy);
        public void Loot(WorldObject worldObject);
        public void ReceiveHits(int hit);
        public bool IsDead();
    }
}
