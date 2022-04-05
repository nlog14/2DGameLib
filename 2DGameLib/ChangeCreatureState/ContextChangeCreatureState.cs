using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.Interfaces;

namespace _2DGameLib.ChangeCreatureState
{
    class ContextChangeCreatureState
    {
        private DefenseItemChangeState defenseItemChangeState;
        public ContextChangeCreatureState(DefenseItemChangeState _defenseItemChangeState)
        {
            this.defenseItemChangeState = _defenseItemChangeState;
        }

        public string ExecuteStateChange(string defenseItemName) =>
            defenseItemChangeState.ChangeCreatureState(defenseItemName);
    }
}
