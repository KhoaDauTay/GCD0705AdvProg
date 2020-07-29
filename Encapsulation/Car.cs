namespace Encapsulation
{
	internal class Car : Vehicle
	{
		public Car(int horsePower, double fuel) : base(horsePower, fuel)
		{
			DefaultFuelConsumption = 3;
		}
	}
}