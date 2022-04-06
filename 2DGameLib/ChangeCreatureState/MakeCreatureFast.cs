using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.ChangeCreatureState;
using _2DGameLib.Interfaces;

namespace _2DGameLib
{
    class MakeCreatureFast : AttackItemChangeState
    {
        /// <summary>
        /// Reference to AttackItem class to access its attributes.
        /// </summary>
        private readonly AttackItem attackItem = new AttackItem();

        /// <summary>
        /// Implements abstract method from AttackItemChangeState
        /// </summary>
        /// <param name="attackItemName"></param>
        /// <returns></returns>
        public override string ChangeCreatureState(string attackItemName)
        {
            if (attackItemName == attackItem.Name) return "You have super speed!";
            return null;
        }
    }
}
