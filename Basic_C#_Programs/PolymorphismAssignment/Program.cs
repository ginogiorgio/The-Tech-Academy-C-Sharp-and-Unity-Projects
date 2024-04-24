using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
	class Program
	{
        // Define the IQuittable interface
        public interface IQuittable
        {
            // Method declaration
            void Quit();
        }

        // Define the Employee class, inheriting from Person and implementing IQuittable
        public class Employee : IQuittable
        {
            // Properties
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // SayName method implementation
            public void SayName()
            {
                Console.WriteLine($"Name: {FirstName} {LastName}");
            }

            // Quit method implementation
            public void Quit()
            {
                Console.WriteLine($"{FirstName} {LastName} has quit their job.");
            }
        }
        public static void Main(string[] args)
		{
            // Create an object of type IQuittable using polymorphism
            IQuittable quittableEmployee = new Employee
            {
                FirstName = "John",
                LastName = "Doe"
            };
            // Call the Quit method on the object
            quittableEmployee.Quit();



            Console.ReadLine();
        }
	}
}
