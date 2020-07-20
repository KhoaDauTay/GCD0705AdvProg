using System;

namespace PointInRectangle
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Point point = new Point(2, 100);
			Rectangle rectangle = new Rectangle(1, 4, 5, 1);
			Console.WriteLine(rectangle.Contains(point));

			Console.ReadLine();
		}
	}
}