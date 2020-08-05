using System;

namespace HotelManagementSystem
{
	internal class Booking
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public Booking(DateTime startDate, DateTime endDate)
		{
			if (startDate >= endDate)
				throw new ArgumentException("EndDate must be greater then StartDate");

			StartDate = startDate;
			EndDate = endDate;
		}

		public bool IsBooked(DateTime startDate, DateTime endDate)
		{
			return !(endDate < StartDate || startDate > EndDate);
		}
	}
}