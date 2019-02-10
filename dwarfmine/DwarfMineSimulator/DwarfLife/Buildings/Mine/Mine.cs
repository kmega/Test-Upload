﻿using System;
using System.Linq;
using System.Collections.Generic;
using DwarfLife.Enums;
using DwarfLife.Dwarfs;
using DwarfLife.Diaries;

namespace DwarfLife.Buildings.Mine
{
    public class Mine
    {
        Shaft[] _shafts;
        public List<Shaft> Shafts 
        { 
            get { return _shafts.OfType<Shaft>().ToList(); }
            private set { _shafts = value.ToArray(); } 
        }
        public List<IDwarf> DwarfsInMine { get; set; }

        public Mine()
        {
            DwarfsInMine = new List<IDwarf>();
            Shafts = new List<Shaft>() { new Shaft("Shaft A"), new Shaft("Shaft B") };
        }

        public Mine(string[] shaftsNames)
        {
            DwarfsInMine = new List<IDwarf>();
            var shafts = new List<Shaft>();
            foreach (string name in shaftsNames)
                 shafts.Add(new Shaft(name));

            Shafts = shafts;
        }
    }
}