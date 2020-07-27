namespace Encapsulation
{
	public class Circle
	{
		public double Radius;

		public double Area
		{
			get
			{
				return 3.14 * Radius * Radius;
			}
			private set { }
		}

		public double Circumference
		{
			get
			{
				return 2 * 3.14 * Radius;
			}
			private set
			{
			}
		}

		public Circle(double radius)
		{
			Radius = radius;
		}
	}
}