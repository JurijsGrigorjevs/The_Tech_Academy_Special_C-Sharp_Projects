using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.
            Employee empl = new Employee() { FirstName = "Sample", LastName = "Student" };
            // Call the superclass method SayName() on the Employee object
            empl.SayName();
            Console.ReadLine();

        }
    }
}
