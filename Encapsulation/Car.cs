using System;

namespace Encapsulation
{
	internal class Car
	{
		internal string Name;
		internal double Price;

		public Car(string name, double price)
		{
			Name = name;

			if (price < 0) throw new ArgumentException("Price can;t be Zero");
			Price = price;
		}
	}
}