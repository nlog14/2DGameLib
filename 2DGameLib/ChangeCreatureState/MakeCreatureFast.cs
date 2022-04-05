using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.ChangeCreatureState;
using _2DGameLib.Interfaces;

namespace _2DGameLib
{
    class MakeCreatureFast : DefenseItemChangeState //IDefenseItem
    {
        private DefenseItem defenseItem = new DefenseItem();
        public override string ChangeCreatureState(string defenseItemName)
        {
            if (defenseItemName == defenseItem.Name) return "You have super speed!";
            return null;
        }
    }
}
