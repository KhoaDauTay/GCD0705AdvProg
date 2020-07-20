namespace PointInRectangle
{
	public class Rectangle
	{
		public Point TopLeft;
		public Point BottomRight;

		public Rectangle()
		{
			TopLeft = new Point();
			BottomRight = new Point();
		}

		public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
		{
			TopLeft = new Point(topLeftX, topLeftY);
			BottomRight = new Point(bottomRightX, bottomRightY);
		}

		public bool Contains(Point point)
		{
			return TopLeft.X < point.X &&
				point.X < BottomRight.X &&
				BottomRight.Y < point.Y &&
				point.Y < TopLeft.Y;
		}
	}
}