using System;

namespace Encapsulation
{
	public class Person
	{
		// private: only current Class can access
		private string _name;

		private int _age;

		// protected: can be accessed in the current Class or Child class
		protected double _salary;

		// public: Can be accessed anywhere
		public string Name;

		public int Age;

		public double Salary
		{
			get
			{
				return _salary;
			}
			set
			{
				if (value < 0) throw new ArgumentException("Salary can't be zero");
				this._salary = value;
			}
		}

		public Person(string name, int age, double salary)
		{
			_name = name;
			Name = name;

			_age = age;
			Age = age;

			_salary = salary;
		}
	}
}