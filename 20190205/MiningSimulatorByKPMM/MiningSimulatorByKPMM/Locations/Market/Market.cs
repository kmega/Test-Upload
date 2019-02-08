﻿using MiningSimulatorByKPMM.DwarfsTypes;
using MiningSimulatorByKPMM.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using MiningSimulatorByKPMM.Locations.Bank;
using MiningSimulatorByKPMM.Reports;

namespace MiningSimulatorByKPMM.Locations.Market
{
	public class Market 
	{
		private ILogger logger;
		public BankAccount shopMoneyAccount = new BankAccount();
		public Dictionary<E_ProductsType, decimal> marketState = new Dictionary<E_ProductsType, decimal>();

		public Market()
		{
			logger = Logger.Instance;
			marketState.Add(E_ProductsType.Food, 0);
			marketState.Add(E_ProductsType.Alcohol, 0);
		}
		
		public void PerformShopping(IBuy customers, GeneralBank bank)
		{
			foreach (var customer in customers)
			{
				if (customer.DwarfType == E_DwarfType.Dwarf_Single && customer.IsAlive)
				{
					BuyProdcutsFromMarket(customer, E_ProductsType.Alcohol, bank);
				}
				else if (customer.DwarfType == E_DwarfType.Dwarf_Father && customer.IsAlive)
				{
					BuyProdcutsFromMarket(customer, E_ProductsType.Food, bank);
				}
			}
		}

		public void BuyProdcutsFromMarket(Dwarf customer, E_ProductsType productType, GeneralBank bank)
		{
			decimal recipe = customer.BankAccount.LastInput / 2;

			decimal amountOfProduct = marketState[productType];
			amountOfProduct += recipe;
			marketState[productType] = amountOfProduct;

			//updating status of bank accounts of Dwarf, Bank and Market
			customer.BankAccount.Withdraw(recipe);
			bank.PayTax(recipe);
			shopMoneyAccount.ReceivedMoney(recipe * 0.77m);
			shopMoneyAccount.CalculateOverallAccount();
			logger.AddLog($"{customer.DwarfType} has spent {recipe.ToString()} on {productType.ToString()} today.");
		}
	}
}
