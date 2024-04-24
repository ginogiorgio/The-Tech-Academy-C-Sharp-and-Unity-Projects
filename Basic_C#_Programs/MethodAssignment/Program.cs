using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Prompt the user to input two numbers
            Console.WriteLine("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number (press Enter if you don't want to enter a second number):");
            string input = Console.ReadLine();
            int number2 = 0;

            // Check if the user entered a second number
            if (!string.IsNullOrEmpty(input))
            {
                number2 = Convert.ToInt32(input);
            }

            // Call the method in the class, passing in one or two numbers
            int result = mathOperations.PerformOperation(number1, number2);

            // Display the result
            Console.WriteLine($"Result of the operation: {result}");
            Console.ReadLine();
        }
	}
}
