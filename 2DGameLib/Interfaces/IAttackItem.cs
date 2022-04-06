using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib.Interfaces
{
    /// <summary>
    /// Strategy Design Pattern & Template Design Pattern
    /// Interface that declares the method the context (ContextChangeCreatureState)
    /// and concrete strategy classes implement (MakeCreatureExtraStrong & MakeCreatureFast)
    /// </summary>
    public interface IAttackItem
    {
        public string ChangeCreatureState(/*string attackItemName*/);
    }
}
