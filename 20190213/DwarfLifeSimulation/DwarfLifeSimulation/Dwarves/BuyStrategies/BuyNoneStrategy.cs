﻿using DwarfLifeSimulation.Enums;
using DwarfLifeSimulation.Interfaces;
using DwarfLifeSimulation.Locations.Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace DwarfLifeSimulation.Dwarves.BuyStrategies
{
    public class BuyNoneStrategy : IBuyStrategy
    {
        public Product Buy(int customerAccountId, int shopAccountId)
        {
            return new Product()
            {
                _productType = ProductType.None,
                _amount = 0.0m
            };
        }
    }
}
