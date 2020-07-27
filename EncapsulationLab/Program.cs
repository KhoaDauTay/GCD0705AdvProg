using System;

namespace EncapsulationLab
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Person person = new Person("ABC", "XYZ", 10);
			Console.WriteLine(person.ToString());

			person.FirstName = "BBBB";

			Console.WriteLine(person.ToString());

			Console.ReadKey();
		}
	}
}