namespace Inheritance
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Student student = new Student();
			student.School = "Greenwich";
			student.Name = "Vinh Hoang";
			student.Address = "Le Loi";

			student.Sleep();

			Employee employee = new Employee();
			employee.Company = "ABC";
			employee.Name = "AAA";
			employee.Address = "CCC";

			Person father = new Person();
			father.Name = "Huy";
			Person mother = new Person();
			mother.Name = "Mai";

			Person child = new Person();
			child.Name = "Huy Mai";
			//child.Father = father;
			//child.Mother = mother;
		}
	}
}