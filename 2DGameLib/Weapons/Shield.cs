using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib.Weapons
{
    public class Shield : AttackItem
    {
        public override string Name
        {
            get { return "Shield"; }
        }

        public override int Damage
        {
            get { return 65; }
        }

        public override string Description
        {
            get { return "A big powerful shield"; }
        }

        public override int Range
        {
            get { return 0; }
        }
    }
}
