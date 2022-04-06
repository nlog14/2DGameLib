using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib.ChangeCreatureState
{
    /// <summary>
    /// Strategy Design Pattern & Template Design Pattern
    /// Common class that declares the method the context (ContextChangeCreatureState)
    /// and concrete strategy classes implement (MakeCreatureExtraStrong & MakeCreatureFast)
    /// </summary>
    abstract class AttackItemChangeState
    {
        public abstract string ChangeCreatureState(string attackItemName);
    }
}
