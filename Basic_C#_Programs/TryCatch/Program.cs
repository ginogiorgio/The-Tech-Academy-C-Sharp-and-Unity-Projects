using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
	class Program
	{
		static void Main(string[] args)
		{

            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            Console.WriteLine("Enter a number to divide each number in the list by:");
            string userInput = Console.ReadLine();

            try
            {
                int divisor = int.Parse(userInput);

                foreach (int number in numbers)
                {
                    try
                    {
                        int result = number / divisor;
                        Console.WriteLine($"{number} divided by {divisor} equals {result}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Cannot divide by zero. Skipping {number}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Program execution continued after the try/catch block.");
                Console.ReadLine();
            }
        }
	}
}
