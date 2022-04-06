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
        private AttackItemChangeState _attackItemChangeState;

        /// <summary>
        /// Constructor to initialize strategy object attackItemChange.
        /// </summary>
        /// <param name="attackItemChangeState"></param>
        public ContextChangeCreatureState(AttackItemChangeState attackItemChangeState)
        {
            this._attackItemChangeState = attackItemChangeState;
        }

        /// <summary>
        /// Executes the strategy object method.
        /// Communicates strictly with the abstract class AttackItemChangeState.
        /// </summary>
        /// <param name="attackItemName"></param>
        /// <returns></returns>
        public string ExecuteChangeCreatureState(string attackItemName) =>
            _attackItemChangeState.ChangeCreatureState(attackItemName);
    }
}
