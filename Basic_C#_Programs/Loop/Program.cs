using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
	class Program
	{
		static void Main(string[] args)
		{

            // Boolean comparison using while statement
            Console.WriteLine("Boolean comparison using while statement:");
            int number = 1;
            while (number <= 5)
            {
                Console.WriteLine($"Number: {number}");
                number++;
            }

            // Boolean comparison using do-while statement
            Console.WriteLine("\nBoolean comparison using do-while statement:");
            int anotherNumber = 1;
            do
            {
                Console.WriteLine($"Another Number: {anotherNumber}");
                anotherNumber++;
            }
            while (anotherNumber <= 5);

            Console.ReadLine(); // To keep console window open
        }
	}
}
