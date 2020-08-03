namespace AbstractClasses
{
	internal class Tesla : IElectricCar, ICar

	{
		public Tesla()
		{
		}

		public Tesla(string name, string model)
		{
			Name = name;
			Model = model;
		}

		public string Name
		{
			get
			{
				return Name;
			}
			set
			{
				Name = value;
			}
		}

		public string GetName()
		{
			return Name;
		}

		public void SetName(string value)
		{
			Name = value;
		}

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