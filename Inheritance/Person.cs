using System;

namespace Inheritance
{
	internal class Person
	{
		public string Name;
		public string Address;
		//public Person Father;
		//public Person Mother;

		public Person(string name, string address)
		{
			Name = name;
			Address = address;
		}

		public void Sleep()
		{
			Console.WriteLine("Sleeping...");
		}
	}
}