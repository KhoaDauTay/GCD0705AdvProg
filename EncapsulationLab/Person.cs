using System;

namespace EncapsulationLab
{
	internal class Person
	{
		private string _firstName;
		private string _lastName;
		private int _age;

		public decimal Salary;

		public string FirstName
		{
			get
			{
				return _firstName + "AAAAXXXXX";
			}
			set
			{
				_lastName = value;
			}
		}

		public string LastName
		{
			get
			{
				return _lastName + "JAHGKASJHKAJ";
			}
			set
			{
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
				if (value < 0) throw new ArgumentException("Age can't be negative");
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
			return FirstName + " " + LastName + " " + Age;
		}
	}
}