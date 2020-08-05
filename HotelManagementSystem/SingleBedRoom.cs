namespace HotelManagementSystem
{
	internal class SingleBedRoom : Room
	{
		public SingleBedRoom() : base()
		{
			Price = 150;
			Capacity = 1;
		}
	}

	internal class DoubleBedRoom : Room
	{
		public DoubleBedRoom() : base()
		{
			Price = 200;
			Capacity = 2;
		}
	}
}