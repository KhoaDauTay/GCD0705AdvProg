using System;

namespace Interfaces
{
	internal class Circle : IDrawable
	{
		private int _radius;

		public Circle()
		{
		}

		public Circle(int r)
		{
			_radius = r;
		}

		public void Draw()
		{
			// TO DO: Draw an circle with _radius
			Console.WriteLine("Radius: " + _radius);
		}
	}
}