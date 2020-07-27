using System;
using System.Collections.Generic;

namespace EncapsulationLab
{
	internal class Team
	{
		private string _name;
		private List<Person> _firstTeam;
		private List<Person> _reserveTeam;

		public IReadOnlyCollection<Person> FirstTeam
		{
			get
			{
				return _firstTeam;
			}
			private set { }
		}

		public IReadOnlyCollection<Person> ReserveTeam
		{
			get
			{
				return _reserveTeam;
			}
			private set { }
		}

		public Team(string name)
		{
			_name = name;
			_firstTeam = new List<Person>();
			_reserveTeam = new List<Person>();
		}

		public void AddPlayer(Person person)
		{
			if (person.Age > 40) _reserveTeam.Add(person);
			_firstTeam.Add(person);
		}

		public void ShowInfo()
		{
			Console.WriteLine("First team has: " + _firstTeam.Count);
			Console.WriteLine("Reserve team has: " + _reserveTeam.Count);
		}
	}
}