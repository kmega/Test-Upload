﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocki
{
	public interface IDiscountCalculator
	{
		decimal Calculate(decimal price, string typ);
	}
}
