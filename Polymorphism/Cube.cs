namespace Polymorphism
{
	internal class Cube : Rectangle
	{
		private int Height;

		public Cube() : base()
		{
			Height = 0;
		}

		public Cube(int l, int w, int h) : base(l, w)
		{
			Height = h;
		}

		// Override method
		public override int CalculateArea()
		{
			return base.CalculateArea() * Height; // Length * Width * Height
		}
	}
}