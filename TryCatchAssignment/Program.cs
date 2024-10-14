using System;


namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
                    try
                    {
                        // Ask the user to enter their age
                        Console.Write("Please enter your age: ");

                        // Read the user input 
                        int age = int.Parse(Console.ReadLine());

                        // Check if the age is valid (non-zero and positive)
                        if (age <= 0)
                        {
                            // Throw an exception 
                            throw new Exception();
                        }

                        // Calculate the year 
                        int birthYear = DateTime.Now.Year - age;

                        // Display the year the user was born
                        Console.WriteLine("You were born in the year: {0}", birthYear);
                        Console.ReadLine();
                    }

                    // Display a general message if an exception was caused by anything else.
                    catch (Exception) 
                    {
                        Console.WriteLine("Please enter a whole digital number, do not enter zero or negative numbers.");
                        Console.ReadLine();
                        
                    }
                   
        }
    }
}
