using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.Interfaces;

namespace _2DGameLib
{
    public abstract class AttackItem : WorldObject, IWeapon
    {
        /// <summary>
        /// Properties of an attack item.
        /// </summary>
       //public abstract string Name { get; }
        public abstract int Damage { get; } //Increases points by +1
        public abstract string Description { get; }
        public abstract int Range { get; }
        
        public override string ToString()
        {
            return $"{Name}:{Description}, dealing {Damage} damage points. Range {Range}";
        }
    }
}
