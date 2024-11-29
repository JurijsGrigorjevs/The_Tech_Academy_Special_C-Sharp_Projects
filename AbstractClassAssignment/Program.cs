using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”
            Employee empl = new Employee() { firstName = "Sample", lastName = "Student" };
            // Call the SayName() method on the object
            empl.SayName();
            Console.ReadLine();
        }
    }
}
