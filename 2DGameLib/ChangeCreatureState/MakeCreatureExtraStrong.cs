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
        public string ChangeCreatureState()
        {
            return "You have super strength!";
        }
    }
}
