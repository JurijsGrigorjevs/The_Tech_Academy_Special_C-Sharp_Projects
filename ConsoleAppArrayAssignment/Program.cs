using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional Array of strings
            string[] brandCarArray = { "Lexus", "Audi", "Jeep", "Volvo", "Kia", "BMW", "Honda", "Fiat", "Suzuki", "Lada" };
            //  Ask the user to select an index of the Array and then display the string at that index on the screen.
            Console.WriteLine("Select a number between 0 and 9: ");
            int stringSelectNumber = Convert.ToInt32(Console.ReadLine());
            bool actualString = false;

            while (!actualString) 
            {
                try
                {
                    Console.WriteLine("Your favorite car brand is " + brandCarArray[stringSelectNumber]);
                    actualString = true;
                }
                catch 
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    stringSelectNumber = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Create a one-dimensional Array of integers.
            int[] luckyNumber = { 1, 3, 5, 7, 8, 25, 33, 55, 77, 777 };
            //  Ask the user to select an index of the Array and then display the integer at that index on the screen.
            Console.WriteLine("Select a lucky number between 0 to 9: ");
            int intSelectNumber = Convert.ToInt32(Console.ReadLine());
            bool actualInt = false;

            while (!actualInt)
            {
                try
                {
                    Console.WriteLine("Your lucky number is " + luckyNumber[intSelectNumber]);
                    actualInt = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    intSelectNumber = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Create a list of strings
            List<string> progrLanglist = new List<string>()
            {
                "C Sharp",
                "C++",
                "JavaScript",
                "Java",
                "Python",
                "MATLAB",
                "Visual Basic",
                "Go",
                "COBOL",
                "PHP"
            };
            // Ask the user to select an index of the list and then display the content at that index on the screen
            Console.WriteLine("\nSelect a number between 0 to 9: ");
            int listSelectNumber = Convert.ToInt32(Console.ReadLine());
            bool actualList = false;

            while (!actualList)
            {
                try
                {
                    Console.WriteLine("Your programming language is  " + progrLanglist[listSelectNumber]);
                    actualList = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    listSelectNumber = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
