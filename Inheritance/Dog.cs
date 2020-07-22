using System;

namespace Inheritance
{
	internal class Dog : Animal
	{
		public override void Eat()
		{
			base.Eat();
			Console.WriteLine("Dog is eating meat...");
		}
	}
}