using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.Interfaces;

namespace _2DGameLib
{
    public abstract class DefenseItem : WorldObject, IWeapon
    {
        /// <summary>
        /// Properties of a defense item.
        /// </summary>
        //public abstract string Name { get; }
        public abstract int Damage{ get; } // Decreases points by -1
        public abstract string Description { get; }

        public override string ToString()
        {
            return $"{Name}:{Description}, dealing {Damage} damage points.";
        }
    }
}
