using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterAssignment
{
	class Program
	{
        // Employee class with generic type parameter
        class Employee<T>
        {
            // Property to hold things of generic type T
            public List<T> Things { get; set; }

            // Constructor to initialize the list
            public Employee()
            {
                Things = new List<T>();
            }
        }

        public static void Main(string[] args)
		{
            // Instantiate an Employee object with type "string" and assign a list of strings
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.Things.Add("Pen");
            stringEmployee.Things.Add("Paper");
            stringEmployee.Things.Add("Laptop");

            // Instantiate an Employee object with type "int" and assign a list of integers
            Employee<int> intEmployee = new Employee<int>();
            intEmployee.Things.Add(10);
            intEmployee.Things.Add(20);
            intEmployee.Things.Add(30);

            // Print all things of string employee
            Console.WriteLine("String Employee Things:");
            foreach (var thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            // Print all things of integer employee
            Console.WriteLine("\nInteger Employee Things:");
            foreach (var thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
	}
}
