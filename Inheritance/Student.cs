namespace Inheritance
{
	internal class Student : Person
	{
		public string School;

		public Student(string name, string address, string school)
			: base(name, address)
		{
			School = school;
		}
	}
}