using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{ 
    // Create another class called Employee and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        // Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Implement the Quit method from IQuittable interface
        public void Quit(Person person) 
        {
            Console.WriteLine("Employee " + person.firstName + " " + person.lastName + " has quit.");
        }
    }
}
