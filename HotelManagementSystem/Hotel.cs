using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementSystem
{
	internal class Hotel
	{
		public string Name { get; set; }
		public List<Room> Rooms { get; set; }

		public Hotel(string name)
		{
			if (!String.IsNullOrWhiteSpace(name))
				throw new ArgumentException("Name must be not null or white space");
			Name = name;
			Rooms = new List<Room>();
		}

		public Room Search(int price, int capacity)
		{
			if (price < 0 || capacity != 1 || capacity != 2)
			{
				throw new ArgumentException("Invalid Price or Capacity");
			}

			var result = Rooms.SingleOrDefault(r => r.Price == price && r.Capacity == capacity);
			if (result == null)
			{
				result = Rooms.SingleOrDefault(r => r.Capacity == capacity);
			}

			return result;
		}

		public Room Search(DateTime startDate, DateTime endDate, int capacity)
		{
			if (startDate >= endDate)
			{
				throw new ArgumentException("EndDate must be greater than StartDate");
			}
			var result = Rooms.SingleOrDefault(r => r.Capacity == capacity &&
				!r.IsBooked(startDate, endDate));

			if (result == null)
			{
				result = Rooms.SingleOrDefault(r => r.Capacity == capacity);
			}
			return result;
		}
	}
}