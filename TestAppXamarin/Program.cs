using System;

namespace TestAppXamarin
{
	class Employee
	{
		public int ID;
		public string Name;
		public Gender gender;
		public int Experience;

		public override string ToString()
		{
			return string.Format(this.Name, this.ID, this.gender, this.Experience);
		}
	}

	public enum Gender
	{
		Unknown,
		Male,
		Female
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			Employee emp1 = new Employee() { ID = 101, Experience = 5, Name = "Steve", gender = Gender.Male };
			Console.WriteLine(emp1.gender.ToString());
			emp1.ToString();
		}
	}
}
