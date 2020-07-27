namespace Encapsulation
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Person person = new Person("Vinh Hoang", 12, 1000);

			// Can access Name
			// because Name is public
			person.Name = "ABC";

			// Can't access the _name outside class Person
			// because _name is private
			person._name = "ABC";

			// Can't access _salary outside class Person
			// because _salary is protected
			person._salary = 10000;
		}
	}
}