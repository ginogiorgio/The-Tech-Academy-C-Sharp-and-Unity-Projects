using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
	class Program
	{
		static void Main(string[] args)
		{

            // Create an instance of the MathOperations class
            MathMethod mathOperations = new MathMethod();

            // Prompt the user for a number
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call each method and display the returned integer
            int doubledNumber = mathOperations.DoubleNumber(userInput);
            Console.WriteLine($"Double of {userInput} is: {doubledNumber}");

            int squaredNumber = mathOperations.SquareNumber(userInput);
            Console.WriteLine($"Square of {userInput} is: {squaredNumber}");

            int incrementedNumber = mathOperations.IncrementNumber(userInput);

            Console.WriteLine($"Incremented value of {userInput} is: {incrementedNumber}");

            Console.ReadLine();
        }
	}
}
