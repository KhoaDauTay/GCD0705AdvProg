using System;

namespace Polymorphism
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(2, 3);
			Cube cube = new Cube(2, 3, 5);

			Console.WriteLine(rectangle.CalculateArea()); // 6
			Console.WriteLine(cube.CalculateArea()); // 30

			Console.ReadLine();

			//	Calculator cal = new Calculator();

			//	Console.WriteLine(cal.Add(1, 2)); // 3

			//	Console.WriteLine(cal.Add(1.2, 2.5)); // 3.7

			//	Console.WriteLine(cal.Add(1, 1.5)); // 2.5

			//	Console.WriteLine(cal.Add(1, 2, 3));
		}
	}
}