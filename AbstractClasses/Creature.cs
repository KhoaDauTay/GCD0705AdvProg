using System;

namespace AbstractClasses
{
	public abstract class Creature
	{
		public string Name;
		public int Age;

		public Creature()
		{
		}

		public Creature(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public void ShowInfo()
		{
			Console.WriteLine(Name);
			Console.WriteLine(Age);
		}

		public abstract void Run();

		public abstract void Eat();
	}
}