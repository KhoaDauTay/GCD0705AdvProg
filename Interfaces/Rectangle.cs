using System;

namespace Interfaces
{
	internal class Rectangle : IDrawable
	{
		private int _height;
		private int _width;

		public Rectangle()
		{
		}

		public Rectangle(int height, int width)
		{
			_height = height;
			_width = width;
		}

		public void Draw()
		{
			// TO DO : draw an rectangle with _width and _height
			Console.WriteLine();
		}
	}
}