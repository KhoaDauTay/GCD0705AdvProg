using System;

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
			person.Salary = 1000;

			// Can't access the _name outside class Person
			// because _name is private
			// person._name = "ABC";

			// Can't access _salary outside class Person
			// because _salary is protected
			// person._salary = 10000;

			Car car = new Car("ABC", -1000);

			car.Name = "ABC";

			Circle circle = new Circle(1);

			Console.WriteLine(circle.Area); // 3.14
																			// circle.Area = 1;
			Console.WriteLine(circle.Area); // 3.14

			Console.WriteLine(circle.Circumference);

			Console.ReadLine();
		}
	}
}