using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib
{
    public abstract class WorldObject 
    {
        public bool Lootable { get; set; }
        public abstract string Name { get; }
        public bool Removable { get; set; }

        public WorldObject()
        {

        }
    }
}
