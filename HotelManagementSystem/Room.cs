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
			if (startDate >= endDate)
			{
				throw new ArgumentException("EndDate must be greater than StartDate");
			}

			var isBooked = false;

			foreach (var booking in Bookings)
			{
				isBooked = booking.IsBooked(startDate, endDate);
				if (isBooked) break;
			}
			return isBooked;
		}
	}
}