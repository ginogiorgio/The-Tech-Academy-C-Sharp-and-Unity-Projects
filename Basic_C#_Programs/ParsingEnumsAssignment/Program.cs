using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
	class Program
	{
        // Enum for days of the week
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        public static void Main(string[] args)
		{
            try
            {
                // Prompt user to enter the current day of the week
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                // Convert user input to the enum type
                DayOfWeek currentDay;
                bool parsed = Enum.TryParse(userInput, out currentDay);

                if (parsed)
                {
                    Console.WriteLine($"You entered: {currentDay}");
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
	}
}
