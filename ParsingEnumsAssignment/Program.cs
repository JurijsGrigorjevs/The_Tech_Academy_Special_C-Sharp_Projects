using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    public class Program
    {
        // Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            bool isValid = false;
            do
            {


                try
                {
                    // Prompt the user to enter the current day of the week.
                    Console.WriteLine("Enter the current day of the week: ");
                    // Read input from the user
                    string inputDay = Console.ReadLine();
                    // Assign the value to a variable of that enum data type you just created
                    DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), inputDay);
                    Console.WriteLine("Today is " + today + "\nHave a great day!");
                }
                // Parsing error
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter the current day of the week");
                }

            }
            while (!isValid);
        }
    }
}
