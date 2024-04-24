using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
	class Program
	{
        // Define the Person class
        public class Person
        {
            // Properties
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Method to say the person's name
            public void SayName()
            {
                Console.WriteLine($"Name: {FirstName} {LastName}");
            }
        }

        // Define the Employee class, inheriting from Person
        public class Employee : Person
        {
            // Additional property for Employee
            public int Id { get; set; }
        }
        public static void Main(string[] args)
		{
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 12345
            };

            // Call the superclass method SayName() on the Employee object
            employee.SayName();

            Console.ReadLine();
        }
	}
}
