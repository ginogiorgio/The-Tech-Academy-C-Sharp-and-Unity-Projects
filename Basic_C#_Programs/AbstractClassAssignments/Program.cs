using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignments
{
	class Program
	{
        public abstract class Person
        {
            // Properties
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Abstract method to say the person's name
            public abstract void SayName();
        }

        // Define the Employee class, inheriting from Person
        public class Employee : Person
        {
            // Implementation of the SayName() method
            public override void SayName()
            {
                Console.WriteLine($"Name: {FirstName} {LastName}");
            }
        }

        public static void Main(string[] args)
		{

            // Instantiate an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName() method on the object
            employee.SayName();

            Console.ReadLine();
        }
	}
}
