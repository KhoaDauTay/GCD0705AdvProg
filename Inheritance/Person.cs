using System;

namespace Inheritance
{
	internal class Person
	{
		public string Name;
		public string Address;
		private string ID;
		protected double weight;
		//public Person Father;
		//public Person Mother;

		public Person()
		{
		}

		public Person(string name, string address)
		{
			Name = name;
			Address = address;
		}

		public void Sleep()
		{
			Console.WriteLine("Sleeping...");
			Console.WriteLine(ID);
		}
	}
}