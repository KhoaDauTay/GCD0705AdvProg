using System;

namespace CustomRandomList
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			RandomList list = new RandomList();
			list.Add("a");
			list.Add("b");
			list.Add("c");
			list.Add("d");
			list.Add("e");
			list.Add("f");

			Console.WriteLine(list.RandomString());

			Console.ReadLine();
		}
	}
}