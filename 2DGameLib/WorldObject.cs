using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib
{
    public abstract class WorldObject 
    {
        public abstract bool Lootable { get; }
        public abstract string Name { get;}
        public abstract bool Removable { get; }
    }
}
