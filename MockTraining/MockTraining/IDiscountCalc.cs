﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTraining
{
    public interface IDiscountCalc
    {
        decimal Calculate(Produkt produkt);
    }
}
