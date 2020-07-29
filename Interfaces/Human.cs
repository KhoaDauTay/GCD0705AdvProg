using System;

namespace Interfaces
{
	internal class Human
	{
		// DRY: Don't Repeat Yourself

		public void Hunt(ICreature creature)
		{
			Console.WriteLine("Human is hunting " + creature.ShowInfo());
		}
	}
}