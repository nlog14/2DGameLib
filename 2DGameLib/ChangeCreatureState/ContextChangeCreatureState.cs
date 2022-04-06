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
        /// Reference to the interface that concrete strategy classes inherit.
        /// </summary>
        private readonly IAttackItem _attackItemChangeState;

        /// <summary>
        /// Constructor to initialize interface IAttackItem.
        /// </summary>
        /// <param name="attackItemChangeState"></param>
        public ContextChangeCreatureState(IAttackItem attackItemChangeState)
        {
            this._attackItemChangeState = attackItemChangeState;
        }

        /// <summary>
        /// Executes the strategy object method.
        /// Communicates strictly with the interface IAttackItem.
        /// </summary>
        /// <param name="attackItemName"></param>
        /// <returns></returns>
        public string ExecuteChangeCreatureState(/*string attackItemName*/) =>
            _attackItemChangeState.ChangeCreatureState(/*attackItemName*/);
    }
}
