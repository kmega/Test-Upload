﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DwarfLifeSimulation.Locations.Bank
{
    class BankAccount
    {
        public decimal OverallMoney { get; set; }
        public decimal DailyIncome { get; set; }

        public BankAccount()
        {
            OverallMoney = 0.0m;
            DailyIncome = 0.0m;
        }
    }
}
