﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pva_arena
{
    class Archer : Fighter
    {
        public Archer(string name, int hP, int dMG, int dodgeChance, int blockChance) : base(name, hP, dMG, dodgeChance, blockChance)
        {
        }
    }
}
