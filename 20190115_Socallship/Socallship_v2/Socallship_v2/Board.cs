﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Socallship_v2
{
	public class Board : IField
	{
		public FieldType[,] Arena;
		public List<Field> GetFields()
		{
			throw new NotImplementedException();
		}
	}
}  
