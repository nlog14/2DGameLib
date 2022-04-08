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
        private readonly IWorldObjects _worldObjectChangeState;

        
        public ContextChangeCreatureState(IWorldObjects worldObjectChangeState)
        {
            this._worldObjectChangeState = worldObjectChangeState;
        }

        public string ExecuteChangeCreatureState() =>
            _worldObjectChangeState.ChangeCreatureState();
    }
}
