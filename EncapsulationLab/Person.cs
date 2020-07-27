namespace EncapsulationLab
{
	internal class Person
	{
		private string _firstName;
		private string _lastName;
		private int _age;

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
				_age = value;
			}
		}

		public Person(string firstName, string lastName, int age)
		{
			_firstName = firstName;
			_lastName = lastName;
			_age = age;
		}

		public override string ToString()
		{
			return FirstName + " " + LastName + " " + Age;
		}
	}
}