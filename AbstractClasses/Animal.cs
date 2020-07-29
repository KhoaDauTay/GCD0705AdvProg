using System;

namespace AbstractClasses
{
	internal class Animal : Creature
	{
		public Animal(string name, int age) : base(name, age)
		{
		}

		public Animal() : base()
		{
		}

		public override void Eat()
		{
			Console.WriteLine("Animal is eating ...");
		}

		public override void Run()
		{
			Console.WriteLine("Animal is running ...");
		}
	}
}