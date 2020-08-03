namespace Polymorphism
{
	internal class Calculator
	{
		public Calculator()
		{
		}

		// Overloading methods
		public int Add(int a, int b)
		{
			return a + b;
		}

		public double Add(double a, double b)
		{
			return a + b;
		}

		public int Add(int a, int b, int c)
		{
			return Add(Add(a, b), c);
		}
	}
}