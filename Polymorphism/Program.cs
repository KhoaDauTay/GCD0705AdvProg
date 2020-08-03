using System;

namespace Polymorphism
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Calculator cal = new Calculator();

			Console.WriteLine(cal.Add(1, 2)); // 3

			Console.WriteLine(cal.Add(1.2, 2.5)); // 3.7

			Console.WriteLine(cal.Add(1, 1.5)); // 2.5
		}
	}
}