using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            List<Employee> classes = new List<Employee>()
            {
                new Employee() {Id = 1, firstName= "Benedict", lastName= "Cumberbatch"},
                new Employee() {Id = 2, firstName= "Joe", lastName= "Caine"},
                new Employee() {Id = 3, firstName= "Daniel", lastName= "Day-Lewis"},
                new Employee() {Id = 4, firstName= "Anthony", lastName= "Hopkins"},
                new Employee() {Id = 5, firstName= "Liam", lastName= "Neeson"},
                new Employee() {Id = 6, firstName= "Joe", lastName= "Smith"},
                new Employee() {Id = 7, firstName= "Ralph", lastName= "Fiennes"},
                new Employee() {Id = 8, firstName= "Daniel", lastName= "Craig"},
                new Employee() {Id = 9, firstName= "Tom", lastName= "Hardy"},
                new Employee() {Id = 10, firstName= "Simon", lastName= "Pegg"},
            };

            // Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.
            List<Employee> emplJoes1 = new List<Employee>();
            foreach (Employee employee in classes)
            {
                if (employee.firstName == "Joe")
                {
                    emplJoes1.Add(employee);
                }
            }
            // The same action again, but this time with a lambda expression.
            List<Employee> emplJoes2 = classes.Where(x => x.firstName == "Joe").ToList();

            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> checkId = classes.Where(x => x.Id > 5).ToList();

            // Employees with first name Joe using foreach loop
            Console.WriteLine("Employees with first name Joe using foreach loop:");
            foreach (Employee employees in emplJoes1)
            {
                Console.WriteLine(employees.firstName + " " + employees.lastName);
            }

            // Employees with first name Joe using lambda expression
            Console.WriteLine("\nEmployees with first name Joe using lambda expression:");
            foreach (Employee employees in emplJoes2)
            {
                Console.WriteLine(employees.firstName + " " + employees.lastName);
            }

            // Employees with Id greater than 5
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (Employee employees in checkId)
            {
                Console.WriteLine(employees.Id + " " + employees.firstName + " " + employees.lastName);
            }
            Console.ReadLine();

        }
    }
}
