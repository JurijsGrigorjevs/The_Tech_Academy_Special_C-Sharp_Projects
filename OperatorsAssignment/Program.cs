using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create two employee objects
            Employee employee1 = new Employee() { Id = 1, FirstName = "Jurijs", LastName = "Grigorjevs" };
            Employee employee2 = new Employee() { Id = 2, FirstName = "Bob", LastName = "Marley" };


            // Compare the employees by Id
            bool employeesEqual = employee1 == employee2;

            if (!employeesEqual)
            {
                Console.WriteLine("Employees have different ID");
            }
            else
            {
                Console.WriteLine("Employees have the same ID");
            }

            Console.ReadLine();

        }
    }
}
