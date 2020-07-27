using System;

namespace EncapsulationLab
{
	internal class Person
	{
		private string _firstName;
		private string _lastName;
		private int _age;

		public decimal Salary
		{
			get
			{
				return Salary;
			}
			set
			{
				if (value < 460)
					throw new ArgumentException("Salary cannot be less than 460");
				Salary = value;
			}
		}

		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				if (value.Length < 4)
					throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
				_lastName = value;
			}
		}

		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				if (value.Length < 4)
					throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
				_lastName = value;
			}
		}

		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value < 0) throw new ArgumentException("Age cannot be zero or a negative integer!");
				_age = value;
			}
		}

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			_firstName = firstName;
			_lastName = lastName;
			_age = age;
			Salary = salary;
		}

		public void IncreaseSalary(decimal percentage)
		{
			if (Age < 30)
			{
				Salary = Salary + Salary * percentage / 200;
			}
			else
			{
				Salary = Salary + Salary * percentage / 100;
			}
		}

		public override string ToString()
		{
			return FirstName + " " + LastName + " " + Age + " " + Salary;
		}
	}
}