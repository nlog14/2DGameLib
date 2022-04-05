using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.ChangeCreatureState;
using _2DGameLib.Interfaces;

namespace _2DGameLib
{
    class MakeCreatureExtraStrong : DefenseItemChangeState 
    {
        /// <summary>
        /// Reference to DefenseItem class to access its attributes.
        /// </summary>
        private readonly DefenseItem defenseItem = new DefenseItem();

        /// <summary>
        /// Implements abstract method from DefenseItemChangeState
        /// </summary>
        /// <param name="defenseItemName"></param>
        /// <returns></returns>
        public override string ChangeCreatureState(string defenseItemName)
        {
            if (defenseItemName == defenseItem.Name) return "You have extra strength!";
            return null;
        }
    }
}
