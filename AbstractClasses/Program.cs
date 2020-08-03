using System;

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

			Tesla tesla = new Tesla("ABC", "XYZ");

			Console.WriteLine(tesla.Name);
			Console.WriteLine(tesla.GetName());

			tesla.SetName("AAA");
			tesla.Name = "AAA";

			tesla.Model = "BBB";
		}
	}
}