﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dwarf_Town.Interfaces
{
    public class Chance : IChance
    {
        public int GenerateChance(int lowerBound, int upperBound)
        {
            Random random = new Random();
            return random.Next(lowerBound, upperBound);
        }
    }
}
