using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("What is your age?");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Have you ever had a DUI?");
			bool DUI = Convert.ToBoolean(Console.ReadLine());
			Console.WriteLine("How many speeding tickets do you have?");
			int ticket = Convert.ToInt32(Console.ReadLine());

			bool qualified = age > 15 && !DUI && ticket <= 3;

			Console.WriteLine("Qualified?");
			Console.WriteLine(Convert.ToString(qualified));
			Console.ReadLine();
		}
	}
}
