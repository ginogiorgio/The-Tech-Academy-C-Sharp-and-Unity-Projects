using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
			// Instantiate the MathOperations class
			MathOperations mathOperations = new MathOperations();

			// Call the method in the class, passing in two numbers
			mathOperations.PerformOperation(5, 8);

			// Call the method in the class again, specifying the parameters by name
			mathOperations.PerformOperation(num1: 10, num2: 15);


		}
	}
}
