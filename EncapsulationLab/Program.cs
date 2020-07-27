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
			try
			{
				person.Age = -10;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			Console.ReadKey();
		}
	}
}