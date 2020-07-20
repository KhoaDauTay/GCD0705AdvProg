namespace StudentSystem
{
	internal class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public double Grade { get; set; }

		public Student()
		{
			Name = "N/A";
			Age = -1;
			Grade = -1;
		}

		public Student(string name, int age, double grade)
		{
			Name = name;
			Age = age;
			Grade = grade;
		}

		public string GetGradeStatus()
		{
			if (Grade < 5) return "Average";
			else return "Excellent";
		}
	}
}