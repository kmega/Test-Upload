﻿using Dwarf_Town.Enums;
using Dwarf_Town.Interfaces;
using System;
using System.Collections.Generic;

namespace Dwarf_Town.Locations
{
    public class Hospital : IChance
    {
        public List<Dwarf> GenerateDwarves(int number)
        {
            List<Dwarf> dwarves = new List<Dwarf>();
            for (int i = 0; i < number; i++)
            {
                dwarves.Add(Generate());
            }
            return dwarves;
        }

        public Dwarf Generate()
        {
            var chance = GenerateChance(1, 100);
            if (chance == 100)
            {
                return new Dwarf(DwarfType.SUICIDE);
            }
            else if (chance >= 1 && chance <= 33)
            {
                return new Dwarf(DwarfType.FATHER);
            }
            else if (chance > 33 && chance <= 66)
            {
                return new Dwarf(DwarfType.IDLER);
            }
            else
            {
                return new Dwarf(DwarfType.SINGLE);
            }
        }

        public int GenerateChance(int lowerBound, int upperBound)
        {
            Random random = new Random();
            return random.Next(lowerBound, upperBound);
        }
    }
}