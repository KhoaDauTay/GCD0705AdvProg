namespace AbstractClasses
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Cannot create an Object from an Abstract class
			// Creature creature = new Creature();

			Animal animal = new Animal();

			Animal animal_2 = new Animal("Snowy", 10);

			Dog dog = new Dog();
		}
	}
}