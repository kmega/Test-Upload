﻿using MiningSimulatorByKPMM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSimulatorByKPMM.Locations.Guild
{
    public  class ValueOfGold : IRandomGenerator
    {
        public int GenerateSignleRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(10, 20);
        }
    }
}