using System;

namespace GCD0705AdvProg
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Person person = new Person();
			person.PrintInfo();
			person.Age = 10;

			Person.PrintClassName();

			Person person_2 = new Person("Vinh Hoang", 31, "Le Loi", Gender.Male);
			person_2.PrintInfo();
			person_2.HappyBirthday();

			Person.PrintClassName();

			Console.ReadLine();
		}
	}
}