namespace Inheritance
{
	internal class Employee : Person
	{
		public string Company;

		public Employee(string name, string address, string company)
			: base(name, address)
		{
			Company = company;
		}
	}
}