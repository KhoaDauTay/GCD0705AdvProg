namespace Encapsulation
{
	internal class Student : Person
	{
		public Student(string name, int age, double salary) : base(name, age, salary)
		{
			// Can access _salary
			// because _salary is protected
			base._salary = salary + 10000;

			// Can access Name
			// because Name is public
			base.Name = "VINH HOANG";

			// Can't access _age
			// because _age is private
			base._age = age + 10;
		}
	}
}