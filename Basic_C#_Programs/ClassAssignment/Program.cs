using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
            // Instantiate the class
            MyMathClass mathClass = new MyMathClass();

            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the method on the entered number and display the output
            mathClass.DivideByTwo(userInput);

            // Call the method with output parameters
            mathClass.MultiplyByTwo(userInput, out int output);
            Console.WriteLine($"Result of multiplying {userInput} by 2 is: {output}");

            // Method overloading
            mathClass.MultiplyByTwo(3.5, out double doubleOutput);
            Console.WriteLine($"Result of multiplying 3.5 by 2 is: {doubleOutput}");

            // Using static class method
            MyStaticClass.PrintMessage("This is a static class method.");

            Console.ReadLine();
        }
	}
}
