﻿using DwarfsCity.DwarfContener;
using System;
using System.Collections.Generic;

namespace DwarfsCity
{
    public class Guild
    {
        public decimal GeneralGuildFunds { get; set; } // Suma podatków, które ogółem posiada Gildia.
        public decimal TheSumOfTaxes { get; set; }// Suma podatków, które w danym dniu ma Gildia
        public void GetTaxesofAllDwarfs(List<Dwarf> dwarfs)
        {
            this.TheSumOfTaxes = 0;
            foreach (Dwarf dwarf in dwarfs)
            {
                
                decimal TaxesOfGuild = 0.25m * dwarf.Backpack.Money;
                decimal EarnedMoney = dwarf.Backpack.Money - TaxesOfGuild;
                dwarf.Backpack.Money = EarnedMoney;
                TheSumOfTaxes += TaxesOfGuild;
            }
            this.GeneralGuildFunds += TheSumOfTaxes;
        }
    }
    //private decimal _guildMoney = 0;

    //public void GetMoneyFromDwarfs(List<Dwarf> dwarfs)
    //{
    //    foreach (var dwarfMoney in dwarfs)
    //    {
    //        _guildMoney += 0.20m*dwarfMoney.Backpack.Money;
    //    }
    //}

    //public decimal GetGuildMoney()
    //{
    //    return _guildMoney;
    //}

    //public bool SpendGiuldMoney(decimal amountOfMoneyToSpend)
    //{
    //    if (_guildMoney < amountOfMoneyToSpend)
    //        return false;
    //    else
    //    {
    //        _guildMoney -= amountOfMoneyToSpend;
    //        return true;
    //    }
    //}


}