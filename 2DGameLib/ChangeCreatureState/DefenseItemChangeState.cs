using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib.ChangeCreatureState
{
    /// <summary>
    /// Strategy Design Pattern & Template Design Pattern
    /// </summary>
    abstract class DefenseItemChangeState
    {
        public abstract string ChangeCreatureState(string defenseItemName);
    }
}
