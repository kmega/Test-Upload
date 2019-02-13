﻿using System;
using System.Collections.Generic;
using DwarfLife.Enums;
using DwarfLife.Diaries;
using DwarfLife.Buildings.Shop;

namespace DwarfLife.Dwarfs
{
    public class DwarfSingle : Dwarf, IDwarf
    {
        public new DwarfTypes DwarfType { get; }

        public DwarfSingle(int id, Places whereAmI = Places.None) : base(id, whereAmI)
        {
            DwarfType = DwarfTypes.Single;
            Alive = true;
            HasWorkedToday = false;
            DiaryHelper.Log(Constans.diaryTarget, string.Format(
                "Dwarf has born. His id = {0}, and his type is: {1}",
                Id, DwarfType));
        }
    }
}