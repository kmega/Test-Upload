﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dwarf_Town.Interfaces
{
    public interface IChance
    {
        int GenerateChance(int lowerBound, int upperBound);
    }
}