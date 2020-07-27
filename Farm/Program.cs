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

			// Can access class Person of Encapsulation project
			// because class Person is public
			Person person = new Person("ABC", 100, 1000);

			// Can't access class Car
			// because class Car is internal
			// and it can't be accessed outside out Encapsulation project
			// Car car = new Car("ABC", 100);
		}
	}
}