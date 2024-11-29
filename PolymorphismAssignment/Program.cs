using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”
            Employee empl = new Employee() { firstName = "Sample", lastName = "Student" };
            // Call the SayName() method on the object
            empl.SayName();
           

            // Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable quittable = empl;
            // Call the Quit method
            quittable.Quit(empl);
            Console.ReadLine();
        }
    }
}
