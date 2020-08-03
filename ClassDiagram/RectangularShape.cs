namespace ClassDiagram
{
	internal abstract class RectangularShape : IShape
	{
		private int width;
		private int height;
		private double area { get; set; }

		public bool contains(int x, int y)
		{
			return true;
		}

		public double getArea()
		{
			return 0;
		}
	}
}