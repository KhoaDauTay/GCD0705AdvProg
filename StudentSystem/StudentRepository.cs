using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem
{
	public class StudentRepository
	{
		private List<Student> Students;

		public StudentRepository()
		{
			Students = new List<Student>();
		}

		public void Create(string name, int age, double grade)
		{
			var student = new Student(name, age, grade);
			Students.Add(student);
		}

		public void Show(string name)
		{
			Student studentToFind = Students.SingleOrDefault(s => s.Name == name);

			if (studentToFind == null)
			{
				Console.WriteLine("DO NOT EXISTS !!!");
			}
			else
			{
				Console.WriteLine("Name:" + studentToFind.Name);
				Console.WriteLine("Age:" + studentToFind.Age);
				Console.WriteLine("Grade:" + studentToFind.GetGradeStatus());
			}
		}
	}
}