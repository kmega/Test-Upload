﻿using System;
using System.Collections.Generic;
using System.Text;
using DwarfLifeSimulation.ApplicationLogic;

namespace DwarfLifeSimulation.Loggers
{
    public interface ILog
    {
        void AddLog(string message);
        void DisplayReport(SimulationState state);
    }
}
