using System;

namespace HotelManagementSystem
{
	internal class Booking
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public Booking(DateTime startDate, DateTime endDate)
		{
			StartDate = startDate;
			EndDate = endDate;
		}
	}
}