﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib.Interfaces
{
    interface IWeapon
    {
        /// <summary>
        /// Factory Design Pattern
        /// </summary>
        string Description { get; }
        int Damage { get; }
    }
}
