using System.Collections.Generic;

namespace Encapsulation
{
	internal class Team
	{
		private IReadOnlyCollection<Person> _players;

		public readonly string Name;

		public string GetName()
		{
			return Name;
		}

		public List<Person> Players
		{
			get;
			set;
		}

		public Team(string _name)
		{
			Name = _name;
		}
	}
}