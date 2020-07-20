using System;

namespace GCD0705AdvProg
{
	public enum Gender
	{
		Male,
		Female
	}

	public enum Salary
	{
		Small = 100,
		Medium = 150,
		Big = 300
	}

	public class Person
	{
		public static void PrintClassName()
		{
			Console.WriteLine("This is Class Person");
			Console.WriteLine(NumberOfStudents);
		}

		// Static properties
		public static int NumberOfStudents = 0;

		//Properties
		public string FullName;

		public int Age;
		public string Address;
		public Gender Gender;
		public Salary Salary;

		// Constructor without parameters
		public Person()
		{
			FullName = "N/A";
			Age = -1;
			Address = "N/A";
			Gender = Gender.Female;
			Salary = Salary.Small;
			NumberOfStudents++;
		}

		// Constructor with parameters
		public Person(string fullName, int age, string address, Gender gender)
		{
			FullName = fullName;
			Age = age;
			Address = address;
			Gender = gender;
			Salary = Salary.Big;
			NumberOfStudents++;
		}

		// Methods
		public void PrintInfo()
		{
			Console.WriteLine(FullName);
			Console.WriteLine(Age);
			Console.WriteLine(Address);
			Console.WriteLine(Gender);
			Console.WriteLine((int)Salary);
		}

		public void HappyBirthday()
		{
			this.PrintInfo();
			Console.WriteLine("Happy birthday ...");
			Age = Age + 1;
			this.PrintInfo();
		}
	}
}