﻿using System;
using System.Collections.Generic;
using MiningSimulatorByKPMM.Enums;
using MiningSimulatorByKPMM.Interfaces;
using MiningSimulatorByKPMM.Locations.Mine.Miningoutputs;
using MiningSimulatorByKPMM.PersonalItems;

namespace MiningSimulatorByKPMM.DwarfsTypes
{
    public class Dwarf
    {
        public E_DwarfType DwarfType { get; private set; }
        public Wallet Wallet { get; private set; }
        public Backpack Backpack { get; set; }
        public bool IsAlive { get; set; }
        public Dwarf(E_DwarfType dwarfType)
        {
            DwarfType = dwarfType;
            SetInitialState();
        }

        private void SetInitialState()
        {
            Backpack = new Backpack();

        }
    }
}