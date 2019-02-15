﻿using Dwarf_Town.Enums;
using Dwarf_Town.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dwarf_Town.Locations.Mine
{
    public class Mine
    {
        public List<Shaft> Shafts;
        private Dictionary<MineralType, int> _oreRegister;

        public Mine()
        {
            Shafts = new List<Shaft>()
            {
                new Shaft(),
                new Shaft()
            };
            _oreRegister = new Dictionary<MineralType, int>()
            {
                {MineralType.DirtyGold,0 },
                {MineralType.Gold,0 },
                {MineralType.Silver,0 },
                {MineralType.Mithril,0 }
            };

        }

        public void DwarvesGoWork(List<IWork> dwarvesVisitMine)
        {
            do
            {
                foreach (var shaft in Shafts)
                {
                    if (shaft.EfficientShaft == true)
                    {
                        if (dwarvesVisitMine.Count >= 5)
                        {
                           shaft.PerformWork(dwarvesVisitMine.GetRange(0, 5));
                           RegistBroughtOutOre(dwarvesVisitMine.SelectMany(i => i.ShowWhatYouBroughtOut()).ToList());
                           dwarvesVisitMine.RemoveRange(0, 5);

                        }
                        else
                        {
                            shaft.PerformWork(dwarvesVisitMine.GetRange(0, dwarvesVisitMine.Count));
                            RegistBroughtOutOre(dwarvesVisitMine.SelectMany(i => i.ShowWhatYouBroughtOut()).ToList());
                            dwarvesVisitMine.RemoveRange(0, dwarvesVisitMine.Count);
                        }
                    }
                }
            } while (dwarvesVisitMine.Count > 0);
        }

        public Dictionary<MineralType, int> ShowMineResults()
        {
            return _oreRegister;
        }
        private void RegistBroughtOutOre(List<MineralType> ores)
        {
            foreach (var ore in ores)
            {
                _oreRegister[ore]++;
            }

        }

    }
}
