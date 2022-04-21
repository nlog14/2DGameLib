using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.Interfaces;

namespace _2DGameLib
{
    class MakeCreatureExtraStrong : IWorldObjects
    {
        /// <summary>
        /// Method that changes a creature's state 
        /// after a creature removed/loot a world object
        /// </summary>
        /// <returns></returns>
        public string ChangeCreatureState()
        {
            return "You have super strength!";
        }
    }
}
