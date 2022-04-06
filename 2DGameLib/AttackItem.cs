using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.Interfaces;

namespace _2DGameLib
{
    public class AttackItem : WorldObject
    {
        /// <summary>
        /// Properties of an attack item.
        /// </summary>
        public int Hitpoint { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }

        public AttackItem()
        {

        }
    }
}
