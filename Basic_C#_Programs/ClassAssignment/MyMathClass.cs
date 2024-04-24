using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
	public class MyMathClass
	{
        // Void method that outputs an integer by dividing the passed data by 2
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Result of dividing {number} by 2 is: {result}");
        }

        // Method with output parameters
        public void MultiplyByTwo(int number, out int result)
        {
            result = number * 2;
        }

        // Method overloading
        public void MultiplyByTwo(double number, out double result)
        {
            result = number * 2;
        }
    }

    // Static class
    public static class MyStaticClass
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
