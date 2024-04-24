using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
	class Program
	{
		static void Main(string[] args)
		{
            // Create a one-dimensional Array of strings
            string[] stringArray = { "Apple", "Banana", "Orange", "Grape", "Pineapple" };

            // Ask the user to select an index of the Array and display the string at that index
            Console.WriteLine("Select an index of the Array (0 to 4):");
            int indexStringArray = Convert.ToInt32(Console.ReadLine());

            if (indexStringArray >= 0 && indexStringArray < stringArray.Length)
            {
                Console.WriteLine($"String at index {indexStringArray}: {stringArray[indexStringArray]}");
            }
            else
            {
                Console.WriteLine("Index does not exist.");
            }

            // Create a one-dimensional Array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index of the Array and display the integer at that index
            Console.WriteLine("\nSelect an index of the Array (0 to 4):");
            int indexIntArray = Convert.ToInt32(Console.ReadLine());

            if (indexIntArray >= 0 && indexIntArray < intArray.Length)
            {
                Console.WriteLine($"Integer at index {indexIntArray}: {intArray[indexIntArray]}");
            }
            else
            {
                Console.WriteLine("Index does not exist.");
            }

            // Create a list of strings
            List<string> stringList = new List<string> { "Cat", "Dog", "Bird", "Fish", "Rabbit" };

            // Ask the user to select an index of the list and display the content at that index
            Console.WriteLine("\nSelect an index of the List (0 to 4):");
            int indexStringList = Convert.ToInt32(Console.ReadLine());

            if (indexStringList >= 0 && indexStringList < stringList.Count)
            {
                Console.WriteLine($"Content at index {indexStringList}: {stringList[indexStringList]}");
            }
            else
            {
                Console.WriteLine("Index does not exist.");
            }

            Console.ReadLine(); // To keep console window open
        }
	}
}
