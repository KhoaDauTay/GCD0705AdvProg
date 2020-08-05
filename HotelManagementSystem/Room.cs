using System;
using System.Collections.Generic;

namespace HotelManagementSystem
{
	internal abstract class Room
	{
		public int Price { get; set; }
		public int Capacity { get; set; }

		public List<Booking> Bookings { get; set; }

		public Room()
		{
			Bookings = new List<Booking>();
		}

		public bool IsBooked(DateTime startDate, DateTime endDate)
		{
			return true;
		}
	}
}