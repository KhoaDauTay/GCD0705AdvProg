using System;

namespace HotelManagementSystem
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Hotel hotel = new Hotel("Hotel");
			hotel.Search(-10, 55);

			Console.ReadLine();
		}
	}
}