using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
	public class MathOperations
	{
        public int PerformOperation(int num)
        {
            // Example: addition operation
            return num + 10;
        }

        public int PerformOperation(decimal num)
        {
            // Example: multiplication operation
            return (int)(num * 2);
        }

        public int PerformOperation(string numString)
        {
            // Example: convert string to int and then perform subtraction
            if (int.TryParse(numString, out int num))
            {
                return num - 5;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return 0;
            }
        }
    }
}
