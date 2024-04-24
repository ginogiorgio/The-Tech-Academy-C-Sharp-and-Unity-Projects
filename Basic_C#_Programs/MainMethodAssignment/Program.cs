using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the first method with an integer input
            int result1 = mathOperations.PerformOperation(5);
            Console.WriteLine($"Result of integer operation: {result1}");

            // Call the second method with a decimal input
            int result2 = mathOperations.PerformOperation(5.5m);
            Console.WriteLine($"Result of decimal operation: {result2}");

            // Call the third method with a string input
            int result3 = mathOperations.PerformOperation("10");
            Console.WriteLine($"Result of string operation: {result3}");

            Console.ReadLine();
        }
	}
}
