﻿using System;
using System.Collections.Generic;
using DwarfLife.Enums;
using DwarfLife.Diaries;

namespace DwarfLife.Dwarfs
{
    internal class DwarfSluggard : Dwarf, IDwarf
    {
        public new DwarfTypes DwarfType { get; }

        public DwarfSluggard(int id, Places whereAmI = Places.None) : base(1)
        {
            DwarfType = DwarfTypes.Sluggard;
            Alive = true;
            DiaryHelper.Log(DiaryTarget.Console, String.Format(
                "Dwarf has born. His id = {0}, and his type is: {1}",
                Id, DwarfType));
        }
    }
}
