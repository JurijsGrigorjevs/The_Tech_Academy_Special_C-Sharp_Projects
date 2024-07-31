using System;


namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("What is your age?");
            // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (YES or NO)");
            // Returns a copy of this string converted to uppercase.
            string answer = Console.ReadLine().ToUpper();
            // The answer should be (equal (==)) - YES
            bool dui = answer == "YES";
            Console.WriteLine("How many speeding tickets do you have?");
            // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for insurance?");
            // Criteria for insurance - age over 15 years AND no DUI AND tickets 3 or less 3
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            Console.WriteLine(qualified);
        }
    }
}
