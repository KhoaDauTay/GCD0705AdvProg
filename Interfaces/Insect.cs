using System;

namespace Interfaces
{
	internal class Insect : ICreature // Implement interface ICreature
	{
		public void Die()
		{
			throw new NotImplementedException();
		}

		public void Eat()
		{
			throw new System.NotImplementedException();
		}

		public void Hunt()
		{
			throw new System.NotImplementedException();
		}

		public void MakeLove()
		{
			throw new System.NotImplementedException();
		}

		public void Run()
		{
			throw new System.NotImplementedException();
		}

		public string ShowInfo()
		{
			return "Insect";
		}

		public void Sleep()
		{
			throw new System.NotImplementedException();
		}
	}
}