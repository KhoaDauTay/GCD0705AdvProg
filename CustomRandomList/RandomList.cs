using System;
using System.Collections.Generic;

namespace CustomRandomList
{
	internal class RandomList : List<string>
	{
		public string RandomString()
		{
			if (Count == 0) return null;

			Random r = new Random();
			int rInt = r.Next(0, Count - 1);
			return this[rInt];
		}
	}
}