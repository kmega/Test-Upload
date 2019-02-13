﻿using Dwarf.Town.Enums;
using Dwarf.Town.Locations.Guild.OreValue;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dwarf.Town.Locations.Guild
{
    public static class GuildFactory
    {

        public static Guild CreateStandardGuild()
        {
            Guild guild = new Guild(new Dictionary<MineralType, IOreValue>
                {
                {MineralType.DirtyGold, new DirtGoldValue()},
                 {MineralType.Gold, new GoldValue()},
                 {MineralType.Silver, new SilverValue()},
                 {MineralType.Mithril, new MithrilValue()}
                }
            );
            return guild;

        }

    }
}
