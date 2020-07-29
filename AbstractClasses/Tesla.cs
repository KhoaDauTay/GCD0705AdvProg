namespace AbstractClasses
{
	internal class Tesla : IElectricCar, ICar

	{
		public string Model { get; set; }
		public string Color { get; set; }

		public void Start()
		{
			// To be implemented
		}

		public void Stop()
		{
			// To be implemented
		}

		public override string ToString()
		{
			// To be implemented
			return base.ToString();
		}
	}
}