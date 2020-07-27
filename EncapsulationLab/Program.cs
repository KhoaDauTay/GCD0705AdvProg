using System;
using System.Collections.Generic;

namespace EncapsulationLab
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//Person person = new Person("ABC", "XYZ", 10, 1000);
			//Console.WriteLine(person.ToString());

			//person.FirstName = "BBBB";

			//Console.WriteLine(person.ToString());
			//try
			//{
			//	person.Age = -10;
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine(e.Message);
			//}

			Team team = new Team("Avengers");
			List<Person> persons = new List<Person>();

			persons.Add(new Person("ABC", "XYZ", 30, 1000));
			persons.Add(new Person("ABC", "XYZ", 50, 1000));

			foreach (var p in persons)
			{
				team.AddPlayer(p);
			}

			team.ShowInfo();

			Console.ReadKey();
		}
	}
}