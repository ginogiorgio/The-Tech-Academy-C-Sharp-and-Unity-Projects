using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
	class Program
	{
        public class Employee
        {
            // Properties
            public int Id { get; set; }
            public string Name { get; set; }

            // Constructor
            public Employee(int id, string name)
            {
                Id = id;
                Name = name;
            }

            // Overloading the "==" operator to compare Employee objects based on their Id property
            public static bool operator ==(Employee emp1, Employee emp2)
            {
                // Check if both objects are null or the same instance
                if (ReferenceEquals(emp1, emp2))
                {
                    return true;
                }

                // Check if either object is null
                if ((emp1 is null) || (emp2 is null))
                {
                    return false;
                }

                // Compare the Id property of the Employee objects
                return emp1.Id == emp2.Id;
            }

            // Overloading the "!=" operator to complement the "==" operator
            public static bool operator !=(Employee emp1, Employee emp2)
            {
                return !(emp1 == emp2);
            }
        }

        public static void Main(string[] args)
		{
            // Create two Employee objects
            Employee emp1 = new Employee(1, "John");
            Employee emp2 = new Employee(2, "Jane");

            // Compare Employee objects using the overloaded "==" operator
            Console.WriteLine($"Are emp1 and emp2 equal? {emp1 == emp2}");
            Console.ReadLine();
        }
	}
}
