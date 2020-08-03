namespace Polymorphism
{
	internal class Rectangle
	{
		private int Length;
		private int Width;

		public Rectangle()
		{
			Length = 0;
			Width = 0;
		}

		public Rectangle(int l, int w)
		{
			Length = l;
			Width = w;
		}

		public virtual int CalculateArea()
		{
			return Length * Width;
		}
	}
}