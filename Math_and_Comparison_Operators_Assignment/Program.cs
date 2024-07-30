using System;
using System.Security.Cryptography;
using System.Security.Policy;


namespace Math_and_Comparison_Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            //Input Hourly  Rate for Person 1
            string hourlyRatePerson1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hoursPerson1 = Console.ReadLine();
            // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded and multiply by 52 weeks.
            int salaryPerson1 = Convert.ToInt32(hourlyRatePerson1) * Convert.ToInt32(hoursPerson1) * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            //Input Hourly  Rate for Person 2
            string hourlyRatePerson2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hoursPerson2 = Console.ReadLine();
            // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded and multiply by 52 weeks.
            int salaryPerson2 = Convert.ToInt32(hourlyRatePerson2) * Convert.ToInt32(hoursPerson2) * 52;

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(salaryPerson1);
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(salaryPerson2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            //Person 1 makes more money than Person 2, and the console will display whether this statement is true or false.
            bool isCompare = salaryPerson1 > salaryPerson2;
            Console.WriteLine(isCompare);
            Console.ReadLine();

        }
    }
}
