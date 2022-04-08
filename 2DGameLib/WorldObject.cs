using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib
{
    public class WorldObject 
    {
        public bool Lootable { get; set; }
        public string Name { get; set; }
        public bool Removable { get; set; }

        public WorldObject()
        {

        }
    }
}
