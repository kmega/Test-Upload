﻿using System;
using System.Collections.Generic;
using System.Text;
using ThorinsCompany.Raports;

namespace ThorinsCompany
{
    public class WorkingGroup
    {
        public Dwarf[] Workers = new Dwarf[5];
        public WorkingGroup(Dwarf[] workers)
        {
            this.Workers = workers;
        }

        public void Clear()
        {
            Workers = null;
            Logger.GetInstance().AddLog("Group has died in fatal accident");
        }

    }
}
