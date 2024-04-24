using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
			Console.WriteLine("Please enter the package weight:");
			int weight = Convert.ToInt32(Console.ReadLine());

			if (weight > 50)
			{
				Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Please enter the package weight:");
				int width = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please enter the package weight:");
				int heigth = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please enter the package weight:");
				int length = Convert.ToInt32(Console.ReadLine());

				int total = width + heigth + length;


				if (total > 50)
				{
					Console.WriteLine("Package too big to be shipped via Package Express.");
					Console.ReadLine();
				}
				else
				{
					double amount = ((width * heigth * length) * weight) / 100;
					decimal totalamount = Convert.ToDecimal(amount);
					Console.WriteLine("Your estimated total for shipping this package is: $" + totalamount);
					Console.WriteLine("Thank you!");
					Console.ReadLine();
				}


			}


		

		}
	}
}
