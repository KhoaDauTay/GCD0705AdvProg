using Encapsulation;
using System;

namespace Farm
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Dog dog = new Dog();
			dog.Bark();
			dog.Bark();

			Puppy puppy = new Puppy();
			puppy.Eat();
			puppy.Bark();
			puppy.Weep();

			Cat cat = new Cat();
			cat.Eat();
			cat.Meow();

			Console.ReadLine();

			Person person = new Person("ABC", 100, 1000);

			Car car = new Car("ABC", 100);
		}
	}
}