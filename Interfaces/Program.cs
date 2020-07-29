namespace Interfaces
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Animal animal = new Animal();

			Insect insect = new Insect();

			Human human = new Human();

			human.Hunt(animal);

			human.Hunt(insect);

			Alien alien = new Alien();

			human.Hunt(alien);

			// Can't create an object from an Interface
			// ICreature creature = new ICreature();
		}
	}
}