using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib
{
    public class AttackItem : WorldObject
    {
        public int Hitpoint { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }
    }
}
