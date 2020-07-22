using System;

namespace Inheritance
{
	internal class Employee : Person
	{
		public string Company;

		public Employee()
		{
		}

		public Employee(string name, string address, string company)
			: base(name, address)
		{
			Company = company;
		}

		public void GotFired(string reasons)
		{
			Console.WriteLine($"{base.Name} got fired because of {reasons}");
		}
	}
}