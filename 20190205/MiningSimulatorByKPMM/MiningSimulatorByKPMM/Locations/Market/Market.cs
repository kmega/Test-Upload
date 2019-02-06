﻿using MiningSimulatorByKPMM.DwarfsTypes;
using MiningSimulatorByKPMM.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSimulatorByKPMM.Locations.Market
{
	public class Market 
	{
		public Market()
		{
			marketState.Add(E_ProductsType.Food, 0);
			marketState.Add(E_ProductsType.Alcohol, 0);
		}

		public Dictionary<E_ProductsType, decimal> marketState = new Dictionary<E_ProductsType, decimal>();
		
		public void PerformShopping(decimal customerMoney, E_DwarfType customerType)
		{
			if(customerType == E_DwarfType.Dwarf_Single)
			{
				BuyProdcutsFromMarket(customerMoney, this, E_ProductsType.Alcohol);
			} else if (customerType == E_DwarfType.Dwarf_Father)
			{
				BuyProdcutsFromMarket(customerMoney, this, E_ProductsType.Food);
			}
		}

		public void BuyProdcutsFromMarket(decimal dailySalary, Market market, E_ProductsType productType)
		{
			decimal spentMoney = dailySalary / 2;
			decimal amountOfProduct = market.marketState[productType];
			amountOfProduct += spentMoney;
			market.marketState[productType] = amountOfProduct;
		}
	}
}
