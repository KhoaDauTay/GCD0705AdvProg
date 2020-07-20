using System;

namespace StudentSystem
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			StudentRepository repos = new StudentRepository();

			repos.Create("Tri", 19, 9.5);
			repos.Create("Thu", 17, 6.5);
			repos.Create("Hoang", 20, 1.5);
			repos.Create("Minh", 19, 2.5);
			repos.Create("Lan", 21, 9.5);

			repos.Show("Tri");
			repos.Show("Minh");

			Console.ReadLine();
		}
	}
}