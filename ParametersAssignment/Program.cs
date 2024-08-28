using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.
            Employee<string> employeeString = new Employee<string>();
            employeeString.things.AddRange(new List<string> { "Tools", "Shoes", "Desktop" });


            // Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.things.AddRange(new List<int> { 1, 2, 3, 4, 5 });


            // Create a loop that prints all of the Things to the Console.
            Console.WriteLine("Employee string things: ");
            foreach (string thing in employeeString.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nEmployee Int things: ");
            foreach(int thing in employeeInt.things) 
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
 