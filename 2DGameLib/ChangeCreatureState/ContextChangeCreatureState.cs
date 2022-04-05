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
        /// <summary>
        /// Reference to abstract class that concrete strategy classes inherit.
        /// </summary>
        private DefenseItemChangeState defenseItemChangeState;

        /// <summary>
        /// Constructor to initialize strategy object defenseItemChange.
        /// </summary>
        /// <param name="_defenseItemChangeState"></param>
        public ContextChangeCreatureState(DefenseItemChangeState _defenseItemChangeState)
        {
            this.defenseItemChangeState = _defenseItemChangeState;
        }

        /// <summary>
        /// Executes the strategy object method.
        /// Communicates strictly with the abstract class DefenseItemChangeState.
        /// </summary>
        /// <param name="defenseItemName"></param>
        /// <returns></returns>
        public string ExecuteStateChange(string defenseItemName) =>
            defenseItemChangeState.ChangeCreatureState(defenseItemName);
    }
}
