﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesForFun.TaxCalculators
{
    public class PersonalTaxCalculator : ITaxCalculator
    {
        public int CalculateTax(int receivedMoney)
        {
            int taxCredit = 8000;
            int actualTax =  (int)((receivedMoney - taxCredit) * 0.18);

            return actualTax;
        }
    }
}
