using System;


namespace BranchingAssignment

{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // The user needs to enter the weight of the package.
            Console.WriteLine("Please enter the package weight:");
            // Converts the specified string representation of a number entered by the user to its equivalent double-precision floating-point number.
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if package is too heavy
            if (weight > 50)
            {
                // End the program if the package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                 
            }
            else
            {
                // The user needs to enter the package width
                Console.WriteLine("Please enter the package width:");
                // Converts the specified string representation of a number entered by the user to its equivalent double-precision floating-point number.
                double width = Convert.ToDouble(Console.ReadLine());

                // The user needs to enter the package height
                Console.WriteLine("Please enter the package height:");
                // Converts the specified string representation of a number entered by the user to its equivalent double-precision floating-point number.
                double height = Convert.ToDouble(Console.ReadLine());

                // The user needs to enter the package length
                Console.WriteLine("Please enter the package length:");
                // Converts the specified string representation of a number entered by the user to its equivalent double-precision floating-point number.
                double length = Convert.ToDouble(Console.ReadLine());

                // Calculate the sum of package dimensions
                double dimensionsTotal = width + height + length;


                // Check if the sum of package dimensions is too big
                if (dimensionsTotal > 50)
                {
                    // End the program if the sum of package dimensions is too big
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Calculate the shipping quote
                    double quote = (width * height * length * weight) / 100;

                    // Display the shipping quote to the user
                    Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
                    Console.WriteLine("Thank you!");
                }

            }
            Console.ReadLine();
        }
    }
}




