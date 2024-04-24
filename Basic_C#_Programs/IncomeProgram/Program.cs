using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeProgram
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Anonymous Income Comparison Program");
			Console.ReadLine();

			Console.WriteLine("Person 1");
			Console.WriteLine("Hourly Rate?");
			double person1Rate = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Hours worked per week?");
			double person1hrs = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Person 2");
			Console.WriteLine("Hourly Rate?");
			double person2Rate = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Hours worked per week?");
			double person2hrs = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Annual salary of Person 1:");
			double person1Salary = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Annual salary of Person 1:");
			double person2Salary = Convert.ToDouble(Console.ReadLine());

			bool comparison = person1Salary > person2Salary;
			Console.WriteLine("Does Person 1 make more money than Person 2?");
			Console.WriteLine(Convert.ToString(comparison));
			Console.ReadLine();


		}
	}
}
