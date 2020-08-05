using System;
using System.Collections.Generic;

namespace HotelManagementSystem
{
	internal class Hotel
	{
		public string Name { get; set; }
		public List<Room> Rooms { get; set; }

		public Hotel(string name)
		{
			Name = name;
			Rooms = new List<Room>();
		}

		public Room Search(int price, int capacity)
		{
			return null;
		}

		public Room Search(DateTime startDate, DateTime endDate, int capacity)
		{
			return null;
		}
	}
}