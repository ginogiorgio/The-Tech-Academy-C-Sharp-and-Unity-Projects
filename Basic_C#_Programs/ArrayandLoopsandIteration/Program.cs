using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayandLoopsandIteration
{
	class Program
	{
		static void Main(string[] args)
		{

            //// A one-dimensional array of strings
            //string[] stringArray = new string[3] { "Hello", "Goodbye", "Welcome" };

            //// Ask the user to input some text
            //Console.WriteLine("Enter some text:");
            //string userInput = Console.ReadLine();

            //// A loop that iterates through each string in the array and adds the user's text input to the end of each string
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] += " " + userInput;
            //}

            //// Loop to print each string in the array on a separate line
            //foreach (string str in stringArray)
            //{
            //    Console.WriteLine(str);
            //}


            ////while (true)
            ////{
            ////    Console.WriteLine("This is an infinite loop. Press Ctrl+C to exit.");
            ////    // Without any condition or break statement, this loop will continue indefinitely.
            ////    // Press Ctrl+C to terminate the program if you run it.
            ////}


            //int counter = 0;
            //while (true)
            //{
            //    Console.WriteLine("This is an infinite loop. Press Ctrl+C to exit.");
            //    counter++;
            //    if (counter >= 10) // Exit loop after 10 iterations
            //    {
            //        break;
            //    }
            //}



            //// Loop with "<" operator
            //Console.WriteLine("Loop with \"<\" operator:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Iteration {i + 1}");
            //}

            //// Loop with "<=" operator
            //Console.WriteLine("\nLoop with \"<=\" operator:");
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine($"Iteration {i + 1}");
            //}


            //// A list of strings where each item is unique
            //List<string> stringList = new List<string> { "Apple", "Banana", "Orange", "Grape", "Pineapple" };

            //// Ask the user to input text to search for in the list
            //Console.WriteLine("Enter text to search for in the list:");
            //string searchText = Console.ReadLine();

            //// A loop that iterates through the list and displays the index of the list that contains matching text
            //bool found = false;
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    if (stringList[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"Text '{searchText}' found at index {i}.");
            //        found = true;
            //        break; // Stop the loop once a match has been found
            //    }
            //}

            //// Add code to the loop that tells a user if they put in text that isn’t in the list
            //if (!found)
            //{
            //    Console.WriteLine($"Text '{searchText}' not found in the list.");
            //}



            //// A list of strings with at least two identical strings
            //List<string> stringList = new List<string> { "Apple", "Banana", "Orange", "Grape", "Banana" };

            //// Ask the user to input text to search for in the list
            //Console.WriteLine("Enter text to search for in the list:");
            //string searchText = Console.ReadLine();

            //// A loop that iterates through the list and displays the indices of the list that contain matching text
            //bool found = false;
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    if (stringList[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"Text '{searchText}' found at index {i}.");
            //        found = true;
            //    }
            //}

            //// Add code to the loop that tells a user if they put in text that isn’t in the list
            //if (!found)
            //{
            //    Console.WriteLine($"Text '{searchText}' not found in the list.");
            //}

            // Create a list of strings with at least two identical strings
            List<string> stringList = new List<string> { "Apple", "Banana", "Orange", "Grape", "Banana" };

            // Create a HashSet to keep track of unique strings
            HashSet<string> uniqueStrings = new HashSet<string>();

            // Create a foreach loop that evaluates each item in the list
            foreach (string str in stringList)
            {
                // Display the string
                Console.Write($"String: {str}");

                // Check if the string has already appeared in the list
                if (uniqueStrings.Contains(str))
                {
                    Console.WriteLine(" (Already appeared in the list)");
                }
                else
                {
                    uniqueStrings.Add(str); // Add the string to the HashSet
                    Console.WriteLine();
                }
            }


            Console.ReadLine(); // To keep console window open
        }
	}
}
