using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib
{
    public class DefenseItem : WorldObject
    {
        /// <summary>
        /// Properties of the defense items a creature has.
        /// </summary>
        public string Name { get; set; }
        public int ReduceHitpoint { get; set; }
        public string Description { get; set; }

    }
}
